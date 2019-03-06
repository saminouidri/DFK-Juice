Imports System.Runtime.InteropServices 'for the API

Public Class Form1
    Dim GlobalPath As String
    Dim GlobalCompile As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("cmd", "/c gcc -o output " + GlobalPath)
        Try
            My.Computer.FileSystem.WriteAllText(GlobalPath, RichTextBox1.Text, False)

            Shell(GlobalCompile)
        Catch ex5 As Exception
            MsgBox("Couldn't run program", vbCritical)
        End Try

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBox1.Text = " #include <stdio.h>
     
    int main()
    {
      printf('Hello world\n');
      return 0;
    }"



    End Sub

    Private Sub SyntaxHighlightingToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SyntaxHighlightingToolStripMenuItem.Click
        Dim SearchText As String
        Dim RTBIndex As Integer




        Dim textEnd As Integer = RichTextBox1.TextLength
        SearchText = "int"
        Dim lastIndex As Integer = RichTextBox1.Text.LastIndexOf(SearchText)



        RTBIndex = 0
        While RTBIndex < lastIndex
            RichTextBox1.Find(SearchText, RTBIndex, textEnd, RichTextBoxFinds.None)
            RichTextBox1.SelectionColor = Color.Red
            RTBIndex = RichTextBox1.Text.IndexOf(SearchText, RTBIndex) + 1
        End While

        SearchText = "long"
        lastIndex = RichTextBox1.Text.LastIndexOf(SearchText)
        RTBIndex = 0
        While RTBIndex < lastIndex
            RichTextBox1.Find(SearchText, RTBIndex, textEnd, RichTextBoxFinds.None)
            RichTextBox1.SelectionColor = Color.Red
            RTBIndex = RichTextBox1.Text.IndexOf(SearchText, RTBIndex) + 1
        End While

        SearchText = "double"
        lastIndex = RichTextBox1.Text.LastIndexOf(SearchText)
        RTBIndex = 0
        While RTBIndex < lastIndex
            RichTextBox1.Find(SearchText, RTBIndex, textEnd, RichTextBoxFinds.None)
            RichTextBox1.SelectionColor = Color.Red
            RTBIndex = RichTextBox1.Text.IndexOf(SearchText, RTBIndex) + 1
        End While

        SearchText = "float"
        lastIndex = RichTextBox1.Text.LastIndexOf(SearchText)
        RTBIndex = 0
        While RTBIndex < lastIndex
            RichTextBox1.Find(SearchText, RTBIndex, textEnd, RichTextBoxFinds.None)
            RichTextBox1.SelectionColor = Color.Red
            RTBIndex = RichTextBox1.Text.IndexOf(SearchText, RTBIndex) + 1
        End While

        SearchText = "char"
        lastIndex = RichTextBox1.Text.LastIndexOf(SearchText)
        RTBIndex = 0
        While RTBIndex < lastIndex
            RichTextBox1.Find(SearchText, RTBIndex, textEnd, RichTextBoxFinds.None)
            RichTextBox1.SelectionColor = Color.Red
            RTBIndex = RichTextBox1.Text.IndexOf(SearchText, RTBIndex) + 1
        End While

        SearchText = "while"
        lastIndex = RichTextBox1.Text.LastIndexOf(SearchText)
        RTBIndex = 0
        While RTBIndex < lastIndex
            RichTextBox1.Find(SearchText, RTBIndex, textEnd, RichTextBoxFinds.None)
            RichTextBox1.SelectionColor = Color.Green
            RTBIndex = RichTextBox1.Text.IndexOf(SearchText, RTBIndex) + 1
        End While

        SearchText = "for"
        lastIndex = RichTextBox1.Text.LastIndexOf(SearchText)
        RTBIndex = 0
        While RTBIndex < lastIndex
            RichTextBox1.Find(SearchText, RTBIndex, textEnd, RichTextBoxFinds.None)
            RichTextBox1.SelectionColor = Color.Green
            RTBIndex = RichTextBox1.Text.IndexOf(SearchText, RTBIndex) + 1
        End While


        SearchText = "void"
        lastIndex = RichTextBox1.Text.LastIndexOf(SearchText)
        RTBIndex = 0
        While RTBIndex < lastIndex
            RichTextBox1.Find(SearchText, RTBIndex, textEnd, RichTextBoxFinds.None)
            RichTextBox1.SelectionColor = Color.Cyan
            RTBIndex = RichTextBox1.Text.IndexOf(SearchText, RTBIndex) + 1
        End While

        SearchText = "return"
        lastIndex = RichTextBox1.Text.LastIndexOf(SearchText)
        RTBIndex = 0
        While RTBIndex < lastIndex
            RichTextBox1.Find(SearchText, RTBIndex, textEnd, RichTextBoxFinds.None)
            RichTextBox1.SelectionColor = Color.Cyan
            RTBIndex = RichTextBox1.Text.IndexOf(SearchText, RTBIndex) + 1
        End While


        SearchText = "0"
        lastIndex = RichTextBox1.Text.LastIndexOf(SearchText)
        RTBIndex = 0
        While RTBIndex < lastIndex
            RichTextBox1.Find(SearchText, RTBIndex, textEnd, RichTextBoxFinds.None)
            RichTextBox1.SelectionColor = Color.Orange
            RTBIndex = RichTextBox1.Text.IndexOf(SearchText, RTBIndex) + 1
        End While


        SearchText = "1"
        lastIndex = RichTextBox1.Text.LastIndexOf(SearchText)
        RTBIndex = 0
        While RTBIndex < lastIndex
            RichTextBox1.Find(SearchText, RTBIndex, textEnd, RichTextBoxFinds.None)
            RichTextBox1.SelectionColor = Color.Orange
            RTBIndex = RichTextBox1.Text.IndexOf(SearchText, RTBIndex) + 1
        End While

        SearchText = "2"
        lastIndex = RichTextBox1.Text.LastIndexOf(SearchText)
        RTBIndex = 0
        While RTBIndex < lastIndex
            RichTextBox1.Find(SearchText, RTBIndex, textEnd, RichTextBoxFinds.None)
            RichTextBox1.SelectionColor = Color.Orange
            RTBIndex = RichTextBox1.Text.IndexOf(SearchText, RTBIndex) + 1
        End While

        SearchText = "3"
        lastIndex = RichTextBox1.Text.LastIndexOf(SearchText)
        RTBIndex = 0
        While RTBIndex < lastIndex
            RichTextBox1.Find(SearchText, RTBIndex, textEnd, RichTextBoxFinds.None)
            RichTextBox1.SelectionColor = Color.Orange
            RTBIndex = RichTextBox1.Text.IndexOf(SearchText, RTBIndex) + 1
        End While

        SearchText = "4"
        lastIndex = RichTextBox1.Text.LastIndexOf(SearchText)
        RTBIndex = 0
        While RTBIndex < lastIndex
            RichTextBox1.Find(SearchText, RTBIndex, textEnd, RichTextBoxFinds.None)
            RichTextBox1.SelectionColor = Color.Orange
            RTBIndex = RichTextBox1.Text.IndexOf(SearchText, RTBIndex) + 1
        End While

        SearchText = "5"
        lastIndex = RichTextBox1.Text.LastIndexOf(SearchText)
        RTBIndex = 0
        While RTBIndex < lastIndex
            RichTextBox1.Find(SearchText, RTBIndex, textEnd, RichTextBoxFinds.None)
            RichTextBox1.SelectionColor = Color.Orange
            RTBIndex = RichTextBox1.Text.IndexOf(SearchText, RTBIndex) + 1
        End While

        SearchText = "6"
        lastIndex = RichTextBox1.Text.LastIndexOf(SearchText)
        RTBIndex = 0
        While RTBIndex < lastIndex
            RichTextBox1.Find(SearchText, RTBIndex, textEnd, RichTextBoxFinds.None)
            RichTextBox1.SelectionColor = Color.Orange
            RTBIndex = RichTextBox1.Text.IndexOf(SearchText, RTBIndex) + 1
        End While

        SearchText = "7"
        lastIndex = RichTextBox1.Text.LastIndexOf(SearchText)
        RTBIndex = 0
        While RTBIndex < lastIndex
            RichTextBox1.Find(SearchText, RTBIndex, textEnd, RichTextBoxFinds.None)
            RichTextBox1.SelectionColor = Color.Orange
            RTBIndex = RichTextBox1.Text.IndexOf(SearchText, RTBIndex) + 1
        End While

        SearchText = "8"
        lastIndex = RichTextBox1.Text.LastIndexOf(SearchText)
        RTBIndex = 0
        While RTBIndex < lastIndex
            RichTextBox1.Find(SearchText, RTBIndex, textEnd, RichTextBoxFinds.None)
            RichTextBox1.SelectionColor = Color.Orange
            RTBIndex = RichTextBox1.Text.IndexOf(SearchText, RTBIndex) + 1
        End While

        SearchText = "9"
        lastIndex = RichTextBox1.Text.LastIndexOf(SearchText)
        RTBIndex = 0
        While RTBIndex < lastIndex
            RichTextBox1.Find(SearchText, RTBIndex, textEnd, RichTextBoxFinds.None)
            RichTextBox1.SelectionColor = Color.Orange
            RTBIndex = RichTextBox1.Text.IndexOf(SearchText, RTBIndex) + 1
        End While

        SearchText = "if"
        lastIndex = RichTextBox1.Text.LastIndexOf(SearchText)
        RTBIndex = 0
        While RTBIndex < lastIndex
            RichTextBox1.Find(SearchText, RTBIndex, textEnd, RichTextBoxFinds.None)
            RichTextBox1.SelectionColor = Color.Magenta
            RTBIndex = RichTextBox1.Text.IndexOf(SearchText, RTBIndex) + 1
        End While

        SearchText = "else"
        lastIndex = RichTextBox1.Text.LastIndexOf(SearchText)
        RTBIndex = 0
        While RTBIndex < lastIndex
            RichTextBox1.Find(SearchText, RTBIndex, textEnd, RichTextBoxFinds.None)
            RichTextBox1.SelectionColor = Color.Magenta
            RTBIndex = RichTextBox1.Text.IndexOf(SearchText, RTBIndex) + 1
        End While

        SearchText = "#include"
        lastIndex = RichTextBox1.Text.LastIndexOf(SearchText)
        RTBIndex = 0
        While RTBIndex < lastIndex
            RichTextBox1.Find(SearchText, RTBIndex, textEnd, RichTextBoxFinds.None)
            RichTextBox1.SelectionColor = Color.Green
            RTBIndex = RichTextBox1.Text.IndexOf(SearchText, RTBIndex) + 1
        End While


        SearchText = "#define"
        lastIndex = RichTextBox1.Text.LastIndexOf(SearchText)
        RTBIndex = 0
        While RTBIndex < lastIndex
            RichTextBox1.Find(SearchText, RTBIndex, textEnd, RichTextBoxFinds.None)
            RichTextBox1.SelectionColor = Color.Green
            RTBIndex = RichTextBox1.Text.IndexOf(SearchText, RTBIndex) + 1
        End While


    End Sub

    Private Sub RedoTextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoTextToolStripMenuItem.Click
        RichTextBox1.SelectionColor = Color.Gray
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Label1.Text = InputBox("Rename ...")
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Try
            My.Computer.FileSystem.WriteAllText(GlobalPath, RichTextBox1.Text, False)
        Catch ex2 As Exception
            MsgBox("Couldn't save project", vbCritical)
        End Try
    End Sub

    Private Sub NewProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewProjectToolStripMenuItem.Click
        Dim ProjectName As String
        Dim Compile As String





        ProjectName = InputBox("Enter project name (spaces not allowed) ...")
        ProjectName = "C:\\" + ProjectName
        Try
            My.Computer.FileSystem.CreateDirectory(ProjectName)
        Catch ex3 As Exception
            MsgBox("Can't create directory on C: drive", vbCritical)
        End Try
        GlobalPath = ProjectName + "\main.c"
        GlobalCompile = ProjectName + "\compile.bat"
        Compile = "

                   gcc -o run   " + GlobalPath + "
                   
                   run.exe

                   set /p DUMMY=Hit ENTER to continue...

                   del run.exe"


        Try
            My.Computer.FileSystem.WriteAllText(ProjectName + "\compile.bat", Compile, False)

            My.Computer.FileSystem.WriteAllText(ProjectName + "\main.c", RichTextBox1.Text, False)
        Catch ex4 As Exception
            MsgBox("Couldn't write to compile.bat or main.c", vbCritical)
        End Try

    End Sub

    Private Sub OpenProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenProjectToolStripMenuItem.Click
        MsgBox("Project Path cannot contain spaces!")
        Dim result As DialogResult = OpenFileDialog1.ShowDialog()
        Dim path As String = OpenFileDialog1.FileName
        Dim Compile2 As String
        Dim path2 As String = path.Replace("main.c", "")

        If result = Windows.Forms.DialogResult.OK Then

            RichTextBox1.LoadFile(path, RichTextBoxStreamType.PlainText)
            GlobalPath = path
            GlobalCompile = path2 + "\compile.bat"
            Compile2 = "

                   gcc -o run   " + GlobalPath + "
                   
                   run.exe

                   set /p DUMMY=Hit ENTER to continue...

                   del run.exe"


            Try
                My.Computer.FileSystem.WriteAllText(path2 + "\compile.bat", Compile2, False)
            Catch ex As Exception
                MsgBox("Couldn't create compile.bat, Make sure project path doesn't already contain a compile.bat")
            End Try
        End If
    End Sub
End Class