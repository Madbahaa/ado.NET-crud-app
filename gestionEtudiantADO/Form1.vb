Imports System.Data.SqlClient

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cnx.Open()
            MsgBox("connection etabli")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ajoutercmd_Click(sender As Object, e As EventArgs) Handles ajoutercmd.Click
        Dim req As String = "insert into etudiant(id,nom,prenom) values('" & idtxt.Text & "','" & nomtxt.Text & "', '" & prenomtxt.Text & "')"
        Dim cmd As New SqlCommand(req, cnx)
        Try
            cmd.ExecuteNonQuery()
            MsgBox("insertion reussite!")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        idtxt.Clear()
        nomtxt.Clear()
        prenomtxt.Clear()

    End Sub

    Private Sub modifiercmd_Click(sender As Object, e As EventArgs) Handles modifiercmd.Click
        Dim modifieur As String = "update etudiant set nom = '" & nommodtxt.Text & "' , prenom = '" & prenommodtxt.Text & "' where id = '" & idmodtxt.Text & "'"
        Dim cmd As New SqlCommand(modifieur, cnx)
        Try
            cmd.ExecuteNonQuery()
            MsgBox("modification reussite")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        idmodtxt.Clear()
        nommodtxt.Clear()
        prenommodtxt.Clear()
    End Sub

    
    Private Sub supprimercmd_Click(sender As Object, e As EventArgs) Handles supprimercmd.Click
        Dim supp As String = "delete from etudiant  where id = '" & idsuppcmd.Text & "'"
        Dim cmd As New SqlCommand(supp, cnx)
        Try
            cmd.ExecuteNonQuery()
            MsgBox("suppression reussite")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        idsuppcmd.Clear()
       
    End Sub
End Class
