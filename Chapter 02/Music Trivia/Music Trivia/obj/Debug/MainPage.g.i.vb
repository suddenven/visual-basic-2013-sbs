﻿

#ExternalChecksum("C:\Users\Sudden\Documents\Visual_Basic_2013_SBS\Chapter 02\Music Trivia\Music Trivia\MainPage.xaml", "{406ea660-64cf-4c82-b6f0-42d48172a799}", "FDE4B49DE28B8D4CCD938A6BC2D6E046")
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On


Namespace Global.Music_Trivia

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
    Partial Class MainPage
        Inherits Global.Windows.UI.Xaml.Controls.Page

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents GuitarImage As Global.Windows.UI.Xaml.Controls.Image
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents AnswerBox As Global.Windows.UI.Xaml.Controls.TextBox
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents AnswerButton As Global.Windows.UI.Xaml.Controls.Button

        Private _contentLoaded As Boolean

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub InitializeComponent()
            If _contentLoaded Then
                Return
            End If
            _contentLoaded = true

            Dim uri As New Global.System.Uri("ms-appx:///MainPage.xaml")
            Global.Windows.UI.Xaml.Application.LoadComponent(Me, uri, Global.Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application)

            GuitarImage = CType(Me.FindName("GuitarImage"), Global.Windows.UI.Xaml.Controls.Image)
            AnswerBox = CType(Me.FindName("AnswerBox"), Global.Windows.UI.Xaml.Controls.TextBox)
            AnswerButton = CType(Me.FindName("AnswerButton"), Global.Windows.UI.Xaml.Controls.Button)
        End Sub
    End Class

End Namespace

