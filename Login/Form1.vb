Public Class Form1



    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click

        Dim NumberOfRows As Integer
        Dim RowData As Object
        Dim Password As String = String.Empty
        If txtUsername.Text = String.Empty Or txtPW.Text = String.Empty Then
            MessageBox.Show("please enter your email and password")
        Else
            'how many records contain the email provided by the user?
            NumberOfRows = MembersTableAdapter.FillByEmail(Library_FINAL_FINALDataSet.Members, txtUsername.Text)
            'if there is one existing record with the email then get the user's record with the getdataby method
            'and put the record (really point to the record) in the object "RowData" then get the email from the object.
            'The dataset's index names will match the names of the columns in the table. 
            'Thus RowData.Password points to the user's password
            If NumberOfRows = 1 Then

                RowData = MembersTableAdapter.GetDataByEmail(txtUsername.Text)(0)
                Password = RowData.Password

                If Password = txtPW.Text Then
                    MessageBox.Show("Login successful")

                    'Me.Hide()
                Else
                    MessageBox.Show("Login unsuccessful")
                    txtPW.Clear()
                End If

            Else
                If txtUsername.Text = String.Empty Or txtPW.Text = String.Empty Then
                    MessageBox.Show("please enter your email and password")
                Else
                    'how many records contain the email provided by the user?
                    NumberOfRows = EmployeesTableAdapter.FillByEmployeeEmail(Library_FINAL_FINALDataSet.Employees, txtUsername.Text)
                    'if there is one existing record with the email then get the user's record with the getdataby method
                    'and put the record (really point to the record) in the object "RowData" then get the email from the object.
                    'The dataset's index names will match the names of the columns in the table. 
                    'Thus RowData.Password points to the user's password
                    If NumberOfRows = 1 Then

                        RowData = EmployeesTableAdapter.GetDataByEmployeeEmail(txtUsername.Text)(0)
                        Password = RowData.Password

                        If Password = txtPW.Text Then
                            MessageBox.Show("Login successful")

                            'Me.Hide()
                        Else
                            MessageBox.Show("Login unsuccessful")
                            txtPW.Clear()
                        End If

                    Else
                        MessageBox.Show("No user has registered with this email, please try a different email or register as a new user")
                    End If
                End If
            End If
        End If

    End Sub


End Class


