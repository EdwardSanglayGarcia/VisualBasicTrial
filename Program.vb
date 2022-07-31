Imports System

Module Program
    Sub Main(args As String())
        'Dim accountObjectWithIntegerParameter As Account = New Account(4)
        'Dim accountObjectWithoutIntegerParameter As Account = New Account()

        'accountObjectWithoutIntegerParameter.VoidSub()
        'Console.WriteLine(accountObjectWithoutIntegerParameter.IntFunction(1, 2))

        'Dim squareObject As Shape = New Square(1, 2)
        'squareObject.GetArea()

        'For Loop
        For loopingVariable As Integer = 1 To 4
            If loopingVariable = 3 Then
                Continue For
            End If
            If loopingVariable = 4 Then
                Exit for
            End If
            Console.WriteLine($"The number is {loopingVariable}")
        Next

        'While Loop
        Dim whileLoopingVariable = 1

        While whileLoopingVariable <= 5
            Console.WriteLine($"The number is {whileLoopingVariable}")
            whileLoopingVariable += 1
        End While

        'Do While Loop
        Dim i As Integer = 1
        Do
            Console.WriteLine("i value: {0}", i)
            i += 1
        Loop While i <= 4

        'Foreach and Typed classes
        Dim studentListFinal As New List(Of Student)
        studentListFinal.Add(New Student With {.StudentId = 1, .GivenName = "Edward", .FamilyName = "Garcia", .AddressDetails = New Address With {.City = "Makati", .Barangay = "Guadalupe Viejo", .Street = "Progreso 1"}})

        Console.WriteLine("List of Students")
        For Each studentData In studentListFinal
            Console.WriteLine(
            $"Student ID = {studentData.StudentId}\t\t" +
            $"Student Name = ({studentData.FamilyName.ToUpper}), {studentData.GivenName} - {studentData.AddressDetails.City}"
                )
        Next


        SampleModule.DoSomethingFirst()
        SampleModule.DoSomethingSecond()





    End Sub
End Module

Class Account

    'Field
    Public AccountId As String
    Public GivenName As String
    Public FamilyName As String

    'Property - 
    Private _bankAccountCode As String
    Public Property BankAccountCode() As String
        Get
            Return _bankAccountCode
        End Get
        Set(value As String)
            _bankAccountCode = value
        End Set
    End Property

    'Methods
    Public Sub VoidSub()
        Console.WriteLine("This is a void!")
    End Sub

    Public Function IntFunction(ByVal firstInput As Integer, ByVal secondInput As Integer) As Integer
        Return firstInput + secondInput
    End Function

    'Contructor
    Public Sub New()
        Console.WriteLine("Thank you for instantiating me! Arigatou~! Onii-chan!")
    End Sub

    Public Sub New(ByVal sampleIntegerInput As Integer)
        Console.WriteLine($"You inserted {sampleIntegerInput}!")
    End Sub

End Class

Class Shape
    Public ShapeName As String
    Protected length As Double
    Protected width As Double
    Public Overridable Sub GetArea()
        Console.WriteLine("The Shape Area is")
    End Sub

    Public Sub New(pLength As Double, pWidth As Double)
        length = pLength
        width = pWidth
    End Sub
End Class

Class Square : Inherits Shape

    Public Sub New(pLength As Double, pWidth As Double)
        MyBase.New(1, pWidth)
    End Sub

    'Virtual
    Public Overrides Sub GetArea()
        Console.WriteLine($"The Square Area is {MyBase.length * MyBase.width}")
    End Sub
End Class


Class Student
    Public StudentId As Integer
    Public GivenName As String
    Public FamilyName As String
    Public AddressDetails As Address
End Class

Class Address
    Public Street As String
    Public City As String
    Public Barangay As String
End Class

'Module
Module SampleModule
    Public Sub DoSomethingFirst()
        Console.WriteLine(NameOf(DoSomethingFirst))
    End Sub
    Public Sub DoSomethingSecond()
        Console.WriteLine(NameOf(DoSomethingSecond))
    End Sub
End Module
