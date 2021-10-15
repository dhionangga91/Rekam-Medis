Public Class MenuUtama

    Private Sub MenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PasienToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasienToolStripMenuItem.Click
        frmPasien.Show()
    End Sub

    Private Sub dokterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DokterToolStripMenuItem.Click
        Frmdokter.Show()
    End Sub

    Private Sub ObatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ObatToolStripMenuItem.Click
        frmobat.Show()
    End Sub

    Private Sub userToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserToolStripMenuItem.Click
        user.Show()
    End Sub

    Private Sub ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserToolStripMenuItem.Click
        user.Show()
    End Sub

    Private Sub PasienToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PasienToolStripMenuItem1.Click
        laporanpasien.Show()
    End Sub

    Private Sub obatToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles obatToolStripMenuItem1.Click
        Laporanobat.Show()
    End Sub

    Private Sub dokterToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DokterToolStripMenuItem1.Click
        Laporandokter.Show()
    End Sub

    Private Sub rekammedisToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RekamMedisToolStripMenuItem.Click
        frmrekammedis.Show()
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Dim a As Integer
        a = MsgBox("Anda yakin akan keluar?", vbYesNo, "Warning")
        If a = vbYes Then
            Me.Close()
        End If
    End Sub

End Class