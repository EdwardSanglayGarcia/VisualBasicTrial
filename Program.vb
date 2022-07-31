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


'Microsoft Windows [Version 10.0.19043.1826]
'(c) Microsoft Corporation. All rights reserved.

'C:\Users\Edward>cd C:\Users\Edward\Documents\Repositories\VisualBasicFinal\VisualBasicConsole

'C:\Users\Edward\Documents\Repositories\VisualBasicFinal\VisualBasicConsole>git remote add https://github.com/EdwardSanglayGarcia/VisualBasicTrial
'fatal: Not a git repository (Or any of the parent directories): .git

'C:\Users\Edward\Documents\Repositories\VisualBasicFinal\VisualBasicConsole>git remote add origin https://github.com/EdwardSanglayGarcia/VisualBasicTrial
'fatal: Not a git repository (Or any of the parent directories): .git

'C:\Users\Edward\Documents\Repositories\VisualBasicFinal\VisualBasicConsole>git remote add origin https://github.com/EdwardSanglayGarcia/VisualBasicTrial
'fatal: Not a git repository (Or any of the parent directories): .git

'C:\Users\Edward\Documents\Repositories\VisualBasicFinal\VisualBasicConsole>git init
'Initialized empty Git repository In C:/Users/Edward/Documents/Repositories/VisualBasicFinal/VisualBasicConsole/.git/

'C:\Users\Edward\Documents\Repositories\VisualBasicFinal\VisualBasicConsole>git remote add https://github.com/EdwardSanglayGarcia/VisualBasicTrial
'usage: git remote add [<options>] <name> <url>

'    -f, --fetch           fetch the remote branches
'    --tags                import all tags And associated objects when fetching
'                          Or do Not fetch any tag at all (--no-tags)
'    -t, --track <branch>  branch(es) to track
'    -m, --master <branch>
'                          master branch
'    --mirror[=(push|fetch)]
'                          Set up remote As a mirror To push To Or fetch from


'C:\Users\Edward\Documents\Repositories\VisualBasicFinal\VisualBasicConsole>git remote add origin https://github.com/EdwardSanglayGarcia/VisualBasicTrial

'C:\Users\Edward\Documents\Repositories\VisualBasicFinal\VisualBasicConsole>git add .

'C:\Users\Edward\Documents\Repositories\VisualBasicFinal\VisualBasicConsole>git commit -m "Initial Codebase"
'[master (root-commit) ba401d8] Initial Codebase
' 27 files changed, 403 insertions(+)
' create mode 100644 Program.vb
' create mode 100644 VisualBasicConsole.vbproj
' create mode 100644 bin/Debug/net6.0/VisualBasicConsole.deps.json
' create mode 100644 bin/Debug/net6.0/VisualBasicConsole.dll
' create mode 100644 bin/Debug/net6.0/VisualBasicConsole.exe
' create mode 100644 bin/Debug/net6.0/VisualBasicConsole.pdb
' create mode 100644 bin/Debug/net6.0/VisualBasicConsole.runtimeconfig.json
' create mode 100644 obj/Debug/net6.0/.NETCoreApp,Version=v6.0.AssemblyAttributes.vb
' create mode 100644 obj/Debug/net6.0/VisualBasicConsole.AssemblyInfo.vb
' create mode 100644 obj/Debug/net6.0/VisualBasicConsole.AssemblyInfoInputs.cache
' create mode 100644 obj/Debug/net6.0/VisualBasicConsole.GeneratedMSBuildEditorConfig.editorconfig
' create mode 100644 obj/Debug/net6.0/VisualBasicConsole.assets.cache
' create mode 100644 obj/Debug/net6.0/VisualBasicConsole.dll
' create mode 100644 obj/Debug/net6.0/VisualBasicConsole.genruntimeconfig.cache
' create mode 100644 obj/Debug/net6.0/VisualBasicConsole.pdb
' create mode 100644 obj/Debug/net6.0/VisualBasicConsole.vbproj.AssemblyReference.cache
' create mode 100644 obj/Debug/net6.0/VisualBasicConsole.vbproj.BuildWithSkipAnalyzers
' create mode 100644 obj/Debug/net6.0/VisualBasicConsole.vbproj.CoreCompileInputs.cache
' create mode 100644 obj/Debug/net6.0/VisualBasicConsole.vbproj.FileListAbsolute.txt
' create mode 100644 obj/Debug/net6.0/apphost.exe
' create mode 100644 obj/Debug/net6.0/ref/VisualBasicConsole.dll
' create mode 100644 obj/Debug/net6.0/refint/VisualBasicConsole.dll
' create mode 100644 obj/VisualBasicConsole.vbproj.nuget.dgspec.json
' create mode 100644 obj/VisualBasicConsole.vbproj.nuget.g.props
' create mode 100644 obj/VisualBasicConsole.vbproj.nuget.g.targets
' create mode 100644 obj/project.assets.json
' create mode 100644 obj/project.nuget.cache

'C:\Users\Edward\Documents\Repositories\VisualBasicFinal\VisualBasicConsole>git push
'fatal: The current branch master has no upstream branch.
'To push the current branch And set the remote as upstream, use

'    git push --Set-upstream origin master


'C:\Users\Edward\Documents\Repositories\VisualBasicFinal\VisualBasicConsole>git push -u origin master
'Enumerating objects :  32, done.
'Counting objects :  100% (32/32), done.
'Delta compression Using up To 4 threads
'Compressing objects :  100% (25/25), done.
'Writing objects :  100% (32/32), 88.33 KiB | 4.21 MiB/s, done.
'Total 32(delta 2), reused 0 (delta 0), pack-reused 0
'remote: Resolving deltas :  100% (2/2), done.
'remote:
'remote: Create a pull request For 'master' on GitHub by visiting:
'remote: https : //github.com/EdwardSanglayGarcia/VisualBasicTrial/pull/New/master
'remote:
'To https//github.com/EdwardSanglayGarcia/VisualBasicTrial
' * [new branch]      master -> master
'branch 'master' set up to track 'origin/master'.

'C:\Users\Edward\Documents\Repositories\VisualBasicFinal\VisualBasicConsole>