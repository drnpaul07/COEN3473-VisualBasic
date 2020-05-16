Imports System.Xml
Imports Newtonsoft.Json
Imports Swashbuckle.AspNetCore.Swagger
Imports Swashbuckle.Swagger

Public Class Form1
    Dim path As String = "C:\CreatedFiles\file.txt"
    Dim info As New Info()
    Public Sub getDetails(info)
        info.name = nameTB.Text
        info.age = ageTB.Text
        info.address = addressTB.Text
    End Sub

    Private Sub txtBtn_Click(sender As Object, e As EventArgs) Handles txtBtn.Click
        getDetails(info)
        Dim wName As String = "Name: " & info.name
        Dim wAge As String = "Age: " & info.age
        Dim wAddress As String = "Address: " & info.address
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(path, True)
        file.WriteLine(wName)
        file.WriteLine(wAge)
        file.WriteLine(wAddress)
        file.Close()
    End Sub

    Private Sub xmlBtn_Click(sender As Object, e As EventArgs) Handles xmlBtn.Click
        getDetails(info)
        Dim settings As XmlWriterSettings = New XmlWriterSettings()
        settings.Indent = True
        Dim writer As XmlWriter = XmlWriter.Create("C:\CreatedFiles\file.xml", settings)
        writer.WriteStartDocument()
        writer.WriteStartElement("Input_Details")
        writer.WriteElementString("Name", info.name)
        writer.WriteElementString("Age", info.age)
        writer.WriteElementString("Address", info.address)
        writer.WriteEndElement()
        writer.WriteEndDocument()
        writer.Close()

    End Sub

    Private Sub jsonBtn_Click(sender As Object, e As EventArgs) Handles jsonBtn.Click
        Dim list As New Info()
        list.name = info.name
        list.age = info.age
        list.address = info.address
        Dim infoJson As String = JsonConvert.SerializeObject(list, Newtonsoft.Json.Formatting.Indented)
        Dim file As IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("C:\CreatedFiles\file.json", True)
        file.WriteLine(infoJson)
        file.Close()
    End Sub

    Private Sub nameTB_TextChanged(sender As Object, e As EventArgs) Handles nameTB.TextChanged

    End Sub
End Class
