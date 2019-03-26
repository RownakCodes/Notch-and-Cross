Module Module1


    'Checking if the player playing cross has won
    Function verificationForCross(ByRef NotchandCrosses(,) As String, ByVal name1 As String) As String
        Dim win As String
        win = 0

        'Vertical Verification:
        If (NotchandCrosses(0, 0) = " X " And NotchandCrosses(2, 0) = " X " And NotchandCrosses(4, 0) = " X ") Then
            Console.WriteLine("Horray! " & name1 & " has won")
            win = 1000

        ElseIf (NotchandCrosses(0, 2) = " X " And NotchandCrosses(2, 2) = " X " And NotchandCrosses(4, 2) = " X ") Then
            Console.WriteLine("Horray! " & name1 & " has won")
            win = 1000

        ElseIf (NotchandCrosses(0, 4) = " X " And NotchandCrosses(2, 4) = " X " And NotchandCrosses(4, 4) = " X ") Then
            Console.WriteLine("Horray! " & name1 & " has won")
            win = 1000


            'Horizontal Verification:
        ElseIf (NotchandCrosses(0, 0) = " X " And NotchandCrosses(0, 2) = " X " And NotchandCrosses(0, 4) = " X ") Then
            Console.WriteLine("Horray! " & name1 & " has won")
            win = 1000

        ElseIf (NotchandCrosses(2, 0) = " X " And NotchandCrosses(2, 2) = " X " And NotchandCrosses(2, 4) = " X ") Then
            Console.WriteLine("Horray! " & name1 & " has won")
            win = 1000

        ElseIf (NotchandCrosses(4, 0) = " X " And NotchandCrosses(4, 2) = " X " And NotchandCrosses(4, 4) = " X ") Then
            Console.WriteLine("Horray! " & name1 & " has won")
            win = 1000



            ' Line: y = x; verification "/"
        ElseIf (NotchandCrosses(4, 0) = " X " And NotchandCrosses(2, 2) = " X " And NotchandCrosses(0, 4) = " X ") Then
            Console.WriteLine("Horray! " & name1 & " has won")
            win = 1000

            'Line: y = -x ; verificaion "\"
        ElseIf (NotchandCrosses(0, 0) = " X " And NotchandCrosses(2, 2) = " X " And NotchandCrosses(4, 4) = " X ") Then
            Console.WriteLine("Horray! " & name1 & " has won")
            win = 1000
        End If

        Return win

    End Function








    'Checking if the player playing Zero has won
    Function verificationForZero(ByRef NotchandCrosses(,) As String, ByVal name1 As String) As String

        Dim win As String
        win = 0

        'Vertical Verification:
        If (NotchandCrosses(0, 0) = " X " And NotchandCrosses(2, 0) = " X " And NotchandCrosses(4, 0) = " X ") Then
            Console.WriteLine("Horray! " & name1 & " has won")
            win = 1000

        ElseIf (NotchandCrosses(0, 2) = " X " And NotchandCrosses(2, 2) = " X " And NotchandCrosses(4, 2) = " X ") Then
            Console.WriteLine("Horray! " & name1 & " has won")
            win = 1000

        ElseIf (NotchandCrosses(0, 4) = " X " And NotchandCrosses(2, 4) = " X " And NotchandCrosses(4, 4) = " X ") Then
            Console.WriteLine("Horray! " & name1 & " has won")
            win = 1000


            'Horizontal Verification:
        ElseIf (NotchandCrosses(0, 0) = " X " And NotchandCrosses(0, 2) = " X " And NotchandCrosses(0, 4) = " X ") Then
            Console.WriteLine("Horray! " & name1 & " has won")
            win = 1000

        ElseIf (NotchandCrosses(2, 0) = " X " And NotchandCrosses(2, 2) = " X " And NotchandCrosses(2, 4) = " X ") Then
            Console.WriteLine("Horray! " & name1 & " has won")
            win = 1000

        ElseIf (NotchandCrosses(4, 0) = " X " And NotchandCrosses(4, 2) = " X " And NotchandCrosses(4, 4) = " X ") Then
            Console.WriteLine("Horray! " & name1 & " has won")
            win = 1000



            ' Line: y = x; verification "/"
        ElseIf (NotchandCrosses(4, 0) = " X " And NotchandCrosses(2, 2) = " X " And NotchandCrosses(0, 4) = " X ") Then
            Console.WriteLine("Horray! " & name1 & " has won")
            win = 1000

            'Line: y = -x ; verificaion "\"
        ElseIf (NotchandCrosses(0, 0) = " X " And NotchandCrosses(2, 2) = " X " And NotchandCrosses(4, 4) = " X ") Then
            Console.WriteLine("Horray! " & name1 & " has won")
            win = 1000
        End If

        Return win

    End Function











    'Cross's trun
    Sub CrossPlayed(ByVal Player1 As String, ByRef NotchandCrosses(,) As String, ByRef turn As Integer, name1 As String)
        Select Case Player1
            Case "1"
                If (NotchandCrosses(0, 0) <> " 1 ") Then
                    Console.WriteLine("Try again")
                    turn = turn - 1
                    Exit Select
                Else
                    NotchandCrosses(0, 0) = " X "
                End If


            Case "2"
                If (NotchandCrosses(0, 2) <> " 2 ") Then
                    Console.WriteLine("Try again")
                    turn = turn - 1
                    Exit Select
                Else
                    NotchandCrosses(0, 2) = " X "
                End If


            Case "3"
                If (NotchandCrosses(0, 4) <> " 3 ") Then
                    Console.WriteLine("Try again")
                    turn = turn - 1
                    Exit Select
                Else
                    NotchandCrosses(0, 4) = " X "
                End If


            Case "4"
                If (NotchandCrosses(2, 0) <> " 4 ") Then
                    Console.WriteLine("Try again")
                    turn = turn - 1
                    Exit Select
                Else
                    NotchandCrosses(2, 0) = " X "
                End If


            Case "5"
                If (NotchandCrosses(2, 2) <> " 5 ") Then
                    Console.WriteLine("Try again")
                    turn = turn - 1
                    Exit Select
                Else
                    NotchandCrosses(2, 2) = " X "
                End If


            Case "6"
                If (NotchandCrosses(2, 4) <> " 6 ") Then
                    Console.WriteLine("Try again")
                    turn = turn - 1
                    Exit Select
                Else
                    NotchandCrosses(2, 4) = " X "
                End If


            Case "7"
                If (NotchandCrosses(4, 0) <> " 7 ") Then
                    Console.WriteLine("Try again")
                    turn = turn - 1
                    Exit Select
                Else
                    NotchandCrosses(4, 0) = " X "
                End If



            Case "8"
                If (NotchandCrosses(4, 2) <> " 8 ") Then
                    Console.WriteLine("Try again")
                    turn = turn - 1
                    Exit Select
                Else
                    NotchandCrosses(4, 2) = " X "
                End If



            Case "9"
                If (NotchandCrosses(4, 4) <> " 9 ") Then
                    Console.WriteLine("Try again")
                    turn = turn - 1
                    Exit Select
                Else
                    NotchandCrosses(4, 4) = " X "
                End If

            Case Else
                Console.WriteLine("" & name1 & " : The character you inputted didn't match any of the grid, please try again")
                turn = turn - 1
        End Select
    End Sub










    'Zero's turn
    Sub ZeroPlayed(ByVal Player1 As String, ByRef NotchandCrosses(,) As String, ByRef turn As Integer, name2 As String)

        Select Case Player1
            Case "1"
                If (NotchandCrosses(0, 0) <> " 1 ") Then
                    Console.WriteLine("Try again")
                    turn = turn - 1
                    Exit Select
                Else
                    NotchandCrosses(0, 0) = " O "
                End If


            Case "2"
                If (NotchandCrosses(0, 2) <> " 2 ") Then
                    Console.WriteLine("Try again")
                    turn = turn - 1
                    Exit Select
                Else
                    NotchandCrosses(0, 2) = " O "
                End If


            Case "3"
                If (NotchandCrosses(0, 4) <> " 3 ") Then
                    Console.WriteLine("Try again")
                    turn = turn - 1
                    Exit Select
                Else
                    NotchandCrosses(0, 4) = " O "
                End If


            Case "4"
                If (NotchandCrosses(2, 0) <> " 4 ") Then
                    Console.WriteLine("Try again")
                    turn = turn - 1
                    Exit Select
                Else
                    NotchandCrosses(2, 0) = " O "
                End If


            Case "5"
                If (NotchandCrosses(2, 2) <> " 5 ") Then
                    Console.WriteLine("Try again")
                    turn = turn - 1
                    Exit Select
                Else
                    NotchandCrosses(2, 2) = " O "
                End If


            Case "6"
                If (NotchandCrosses(2, 4) <> " 6 ") Then
                    Console.WriteLine("Try again")
                    turn = turn - 1
                    Exit Select
                Else
                    NotchandCrosses(2, 4) = " O "
                End If


            Case "7"
                If (NotchandCrosses(4, 0) <> " 7 ") Then
                    Console.WriteLine("Try again")
                    turn = turn - 1
                    Exit Select
                Else
                    NotchandCrosses(4, 0) = " O "
                End If



            Case "8"
                If (NotchandCrosses(4, 2) <> " 8 ") Then
                    Console.WriteLine("Try again")
                    turn = turn - 1
                    Exit Select
                Else
                    NotchandCrosses(4, 2) = " O "
                End If



            Case "9"
                If (NotchandCrosses(4, 4) <> " 9 ") Then
                    Console.WriteLine("Try again")
                    turn = turn - 1
                    Exit Select
                Else
                    NotchandCrosses(4, 4) = " O "
                End If

            Case Else
                Console.WriteLine("" & name2 & " : The character you inputted didn't match any of the grid, please try again")
                turn = turn - 1
        End Select
    End Sub










    Sub Main()
        Dim NotchandCrosses(4, 4), win, win2, Player1, choice, Empty As String
        Dim result As Integer
        Empty = ""
        ' Inputing the names of the player

        Dim name1, name2 As String
        Console.WriteLine("Wellcome to the Notch and Crosses game")

        Console.WriteLine("Player 1, Enter your name: ")
        name1 = Console.ReadLine()

        Console.WriteLine("Player 2, Enter your name: ")
        name2 = Console.ReadLine()



        Console.Clear()
        Console.WriteLine("{0} do you want a cross or a zero? (Enter X or 0)", name1)
        choice = Console.ReadLine()
        'Giving the option to chose either 0 or X
        If (choice = "0") Then
            name1 = Empty
            name1 = name2
            name2 = Empty
        End If


        'Creating the ARRAY OF THE GAME

        NotchandCrosses(0, 0) = " 1 "
        NotchandCrosses(0, 1) = "|"
        NotchandCrosses(0, 2) = " 2 "
        NotchandCrosses(0, 3) = "|"
        NotchandCrosses(0, 4) = " 3 "

        NotchandCrosses(1, 0) = "----"
        NotchandCrosses(1, 2) = "----"
        NotchandCrosses(1, 4) = "----"

        NotchandCrosses(2, 0) = " 4 "
        NotchandCrosses(2, 1) = "|"
        NotchandCrosses(2, 2) = " 5 "
        NotchandCrosses(2, 3) = "|"
        NotchandCrosses(2, 4) = " 6 "

        NotchandCrosses(3, 0) = "----"
        NotchandCrosses(3, 2) = "----"
        NotchandCrosses(3, 4) = "----"

        NotchandCrosses(4, 0) = " 7 "
        NotchandCrosses(4, 1) = "|"
        NotchandCrosses(4, 2) = " 8 "
        NotchandCrosses(4, 3) = "|"
        NotchandCrosses(4, 4) = " 9 "

        Console.Clear()

        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("")


        For indexRow = 0 To 4
            For indexColumn = 0 To 4
                Console.Write(NotchandCrosses(indexRow, indexColumn))
            Next

            Console.WriteLine("")
        Next


        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("")









        For turn = 4 To 12
            win = 0
            win2 = 0

            'Checking if anyone won
            win = verificationForCross(NotchandCrosses, name1)
            win2 = verificationForZero(NotchandCrosses, name1)

            win = CInt(win)
            win2 = CInt(win2)



            If (win = 1000 Or win2 = 1000) Then

                Exit For


            Else
                result = turn Mod 2
                If (result = 0) Then
                    Console.WriteLine("" & name1 & " : Which box do you want to put a cross on?(enter the respective letter)")
                    Player1 = Console.ReadLine()

                    CrossPlayed(Player1, NotchandCrosses, turn, name1)



                Else

                    Console.WriteLine("" & name2 & " :Which box do you want to put a zero on?(enter the respective letter)")
                    Player1 = Console.ReadLine()

                    ZeroPlayed(Player1, NotchandCrosses, turn, name2)

                End If

            End If

            Console.Clear()





            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")



            'Printing the new array with the new input
            For indexRow = 0 To 4
                For indexColumn = 0 To 4
                    Console.Write(NotchandCrosses(indexRow, indexColumn))
                Next

                Console.WriteLine("")
            Next


            If (win = 0 And win2 = 0 And turn = 12) Then
                Console.Clear()
                Console.WriteLine("This is a draw between {0} and {1}", name1, name2)
                Exit For
            End If
        Next


        Console.WriteLine("Thank you for playing the game..   <3")

    End Sub


End Module