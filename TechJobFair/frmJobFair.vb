' Program Name: Tech Job Fair
' Developer:    Tu Tong
' Date:         Septemper 26, 2017
' Purpose:      This application displays a welcome screen for the
'               Tech Job Fair. The user can choose an option 
'               to view the date and location.

Public Class frmJobFair
    Private Sub btnViewDetails_Click(sender As Object, e As EventArgs) Handles btnViewDetails.Click
        ' This code is executed when user taps or clicks the View Details button.
        ' It displays the job Date and Location labels, disables View Job Detail button, 
        ' and enables the Exit Window button.

        lblLocation.Visible = True
        lblDate.Visible = True
        lblRoom.Visible = True

        btnViewDetails.Enabled = False
        btnExit.Enabled = True

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' This code is executed when user taps or clicks the Exit Window button.
        ' It closes the window and terminates the program execution.

        Close()

    End Sub
End Class
