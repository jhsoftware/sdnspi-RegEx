Imports JHSoftware.SimpleDNS.Plugin

Public Class RegExPlugIn
  Implements ILookupHost
  Implements IOptionsUI

  Private MatchListIPv4 As List(Of MatchItem)
  Private MatchListIPv6 As List(Of MatchItem)

  Public Property Host As IHost Implements IPlugInBase.Host

  Private Class MatchItem
    Friend RegEx As System.Text.RegularExpressions.Regex
    Friend IP As SdnsIP
    Friend TTL As Integer
  End Class


#Region "readonly properties"

  Public Function GetPlugInTypeInfo() As TypeInfo Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.GetTypeInfo
    With GetPlugInTypeInfo
      .Name = "Regular Expressions"
      .Description = "Respond with same IP address to all requests for host names matching a regular expression"
      .InfoURL = "https://simpledns.plus/plugin-regex"
    End With
  End Function

#End Region

#Region "not implemented"
  Public Function InstanceConflict(ByVal configXML1 As String, ByVal configXML2 As String, ByRef errorMsg As String) As Boolean Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.InstanceConflict
    Return False
  End Function

  Public Function StartService() As Threading.Tasks.Task Implements IPlugInBase.StartService
    Return Threading.Tasks.Task.CompletedTask
  End Function

  Public Sub StopService() Implements IPlugInBase.StopService
  End Sub

#End Region

  Public Sub LoadConfig(ByVal config As String, ByVal instanceID As Guid, ByVal dataPath As String) Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.LoadConfig
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
      mi.IP = SdnsIP.Parse(elem.GetAttribute("ip"))
      mi.TTL = Integer.Parse(elem.GetAttribute("ttl"))
      If mi.IP.IPVersion = 4 Then
        MatchListIPv4.Add(mi)
      Else
        MatchListIPv6.Add(mi)
      End If
    Next
  End Sub

  Public Function LookupHost(name As DomName, ipv6 As Boolean, req As IRequestContext) As Threading.Tasks.Task(Of LookupResult(Of SdnsIP)) Implements ILookupHost.LookupHost
    Dim hn As String = name.ToString(True)
    For Each mi In If(ipv6, MatchListIPv6, MatchListIPv4)
      If mi.RegEx.IsMatch(hn) Then Return Threading.Tasks.Task.FromResult(New LookupResult(Of SdnsIP) With {.Value = mi.IP, .TTL = mi.TTL})
    Next
    Return Threading.Tasks.Task.FromResult(Of LookupResult(Of SdnsIP))(Nothing)
  End Function

  Public Function GetOptionsUI(ByVal instanceID As Guid, ByVal dataPath As String) As OptionsUI Implements IOptionsUI.GetOptionsUI
    Return New OptionsCtrl
  End Function

End Class
