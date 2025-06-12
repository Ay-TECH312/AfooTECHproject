Imports MySql.Data.MySqlClient
Imports System.IO
Public Class AdminRecord

    Private Sub adminBackBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles adminBackBTN.Click
        Me.Close()
        ViewAmin.Show()
    End Sub

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
        Overlay.Close()
        Admin_Dashboard.Show()
    End Sub

    Private Sub AdminRecord_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Functions.staffRecord()
    End Sub
End Class