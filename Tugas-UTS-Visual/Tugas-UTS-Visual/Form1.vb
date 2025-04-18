
Public Class Form1

    Private Sub Loadmenu(control As UserControl)
        PanelContent.Controls.Clear()
        control.Dock = DockStyle.Fill
        PanelContent.Controls.Add(control)
    End Sub

    Private Sub DataManagementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataManagementToolStripMenuItem.Click
        Loadmenu(New Data_Management)
    End Sub

    Private Sub TransactionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransactionToolStripMenuItem.Click
        Loadmenu(New Transaction)
    End Sub

End Class
