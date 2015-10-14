Imports JHSoftware.SimpleDNS.Plugin

Public Class RegExPlugIn
  Implements IGetHostPlugIn

  Private MatchListIPv4 As List(Of MatchItem)
  Private MatchListIPv6 As List(Of MatchItem)

  Private Class MatchItem
    Friend RegEx As System.Text.RegularExpressions.Regex
    Friend IP As IPAddress
    Friend TTL As Integer
  End Class

#Region "events"
  Public Event LogLine(ByVal text As String) Implements IGetHostPlugIn.LogLine
  Public Event AsyncError(ByVal ex As System.Exception) Implements JHSoftware.SimpleDNS.Plugin.IGetHostPlugIn.AsyncError
  Public Event SaveConfig(ByVal config As String) Implements JHSoftware.SimpleDNS.Plugin.IGetHostPlugIn.SaveConfig
#End Region

#Region "readonly properties"

  Public Function GetPlugInTypeInfo() As JHSoftware.SimpleDNS.Plugin.IPlugInBase.PlugInTypeInfo Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.GetPlugInTypeInfo
    With GetPlugInTypeInfo
      .Name = "Regular Expressions"
      .Description = "Respond with same IP address to all requests for host names matching a regular expression"
      .InfoURL = "http://www.simpledns.com/plugin-regex"
      .ConfigFile = False
      .MultiThreaded = False
    End With
  End Function

#End Region

#Region "not implemented"
  Public Function InstanceConflict(ByVal configXML1 As String, ByVal configXML2 As String, ByRef errorMsg As String) As Boolean Implements JHSoftware.SimpleDNS.Plugin.IGetHostPlugIn.InstanceConflict
    Return False
  End Function

  Public Function GetDNSAskAbout() As DNSAskAboutGH Implements JHSoftware.SimpleDNS.Plugin.IGetHostPlugIn.GetDNSAskAbout
    With GetDNSAskAbout
      .ForwardIPv4 = True
      .ForwardIPv6 = True
    End With
  End Function

  Public Sub LoadState(ByVal stateXML As String) Implements JHSoftware.SimpleDNS.Plugin.IGetHostPlugIn.LoadState
  End Sub

  Public Function SaveState() As String Implements JHSoftware.SimpleDNS.Plugin.IGetHostPlugIn.SaveState
    Return ""
  End Function

  Public Sub StartService() Implements IGetHostPlugIn.StartService
  End Sub

  Public Sub StopService() Implements IGetHostPlugIn.StopService
  End Sub

  Public Sub LookupReverse(ByVal req As IDNSRequest, ByRef resultName As DomainName, ByRef resultTTL As Integer) Implements IGetHostPlugIn.LookupReverse
    Throw New NotSupportedException
  End Sub

  Public Sub LookupTXT(ByVal req As IDNSRequest, ByRef resultText As String, ByRef resultTTL As Integer) Implements JHSoftware.SimpleDNS.Plugin.IGetHostPlugIn.LookupTXT
    Throw New NotSupportedException
  End Sub

#End Region

#Region "other methods"
  Public Sub LoadConfig(ByVal config As String, ByVal instanceID As Guid, ByVal dataPath As String, ByRef maxThreads As Integer) Implements JHSoftware.SimpleDNS.Plugin.IGetHostPlugIn.LoadConfig
    MatchListIPv4 = New List(Of MatchItem)
    MatchListIPv6 = New List(Of MatchItem)
    If config.Length = 0 Then Exit Sub
    Dim doc As New Xml.XmlDocument
    Dim root As Xml.XmlElement = doc.CreateElement("root")
    doc.AppendChild(root)
    Dim elem As Xml.XmlElement
    root.InnerXml = config
    Dim mi As MatchItem
    For Each elem In root.GetElementsByTagName("match")
      If Not elem.HasAttribute("regex") Then Continue For
      If Not elem.HasAttribute("ip") Then Continue For
      If Not elem.HasAttribute("ttl") Then Continue For
      mi = New MatchItem
      mi.RegEx = New System.Text.RegularExpressions.Regex(elem.GetAttribute("regex"), Text.RegularExpressions.RegexOptions.Compiled)
      mi.IP = IPAddress.Parse(elem.GetAttribute("ip"))
      mi.TTL = Integer.Parse(elem.GetAttribute("ttl"))
      If mi.IP.IPVersion = 4 Then
        MatchListIPv4.Add(mi)
      Else
        MatchListIPv6.Add(mi)
      End If
    Next
  End Sub

  Public Sub Lookup(ByVal req As IDNSRequest, ByRef resultIP As IPAddress, ByRef resultTTL As Integer) Implements IGetHostPlugIn.Lookup
    Dim hn As String = req.QName.ToStringNative
    For Each mi In If(req.QType = 1US, MatchListIPv4, MatchListIPv6)
      If mi.RegEx.IsMatch(hn) Then
        resultIP = mi.IP
        resultTTL = mi.TTL
        Exit Sub
      End If
    Next
    resultIP = Nothing
  End Sub

  Public Function GetOptionsUI(ByVal instanceID As Guid, ByVal dataPath As String) As OptionsUI Implements IGetHostPlugIn.GetOptionsUI
    Return New OptionsCtrl
  End Function

#End Region


End Class
