Imports System.Runtime.InteropServices 'for the API

Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Process.Start("cmd", "/c g++ -o test M:\helloworld\main.c")
        My.Computer.FileSystem.WriteAllText("M:\helloworld\main.c", RichTextBox1.Text, False)

        Shell("compile.bat")


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBox1.Text = " #include <stdio.h>
     
    int main()
    {
      printf('Hello world\n');
      return 0;
    }"
        Timer1.Interval = 1000
        Timer1.Enabled = True
        Timer1.Start()
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged


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
        WebBrowser1.Navigate("C:\")
    End Sub


End Class