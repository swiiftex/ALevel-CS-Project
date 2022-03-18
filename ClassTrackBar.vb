﻿Imports System.ComponentModel

Public Class DoubleTrackBar
    Inherits Control

    Public Sub New()
        Me.DoubleBuffered = True
        Me.SetDefaults()
    End Sub

    Private Sub SetDefaults()
        'Added these to set to a decent size when a new one is added to the form
        Me.Width = 200
        Me.Height = 50

        Me.Orientation = Orientation.Horizontal
        Me.SmallChange = 1
        Me.Maximum = 400
        Me.Minimum = 0
        Me.ValueLeft = 0
        Me.ValueRight = 300
    End Sub

#Region " Private Fields "

    Private leftThumbState As VisualStyles.TrackBarThumbState
    Private rightThumbState As VisualStyles.TrackBarThumbState

    Private draggingLeft, draggingRight As Boolean
#End Region

#Region " Enums "

    Public Enum Thumbs
        None = 0
        Left = 1
        Right = 2
    End Enum

#End Region

#Region " Properties "

    Private _SelectedThumb As Thumbs
    ''' <summary>
    ''' Gets the thumb that had focus last.
    ''' </summary>
    ''' <returns>The thumb that had focus last.</returns>
    <Description("The thumb that had focus last.")>
    Public Property SelectedThumb() As Thumbs
        Get
            Return _SelectedThumb
        End Get
        Private Set(ByVal value As Thumbs)
            _SelectedThumb = value
        End Set
    End Property

    Private _ValueLeft As Integer
    ''' <summary>
    ''' Gets or sets the position of the left slider.
    ''' </summary>
    ''' <returns>The position of the left slider.</returns>
    <Description("The position of the left slider.")>
    Public Property ValueLeft() As Integer
        Get
            Return _ValueLeft
        End Get
        Set(ByVal value As Integer)
            If value < Me.Minimum OrElse value > Me.Maximum Then
                Throw New ArgumentException(String.Format("Value of '{0}' is not valid for 'ValueLeft'. 'ValueLeft' should be between 'Minimum' and 'Maximum'.", value.ToString()), "ValueLeft")
            End If
            If value > Me.ValueRight Then
                Throw New ArgumentException(String.Format("Value of '{0}' is not valid for 'ValueLeft'. 'ValueLeft' should be less than or equal to 'ValueRight'.", value.ToString()), "ValueLeft")
            End If
            _ValueLeft = value

            Me.OnValueChanged(EventArgs.Empty)
            Me.OnLeftValueChanged(EventArgs.Empty)

            Me.Invalidate()
        End Set
    End Property

    Private _ValueRight As Integer
    ''' <summary>
    ''' Gets or sets the position of the right slider.
    ''' </summary>
    ''' <returns>The position of the right slider.</returns>
    <Description("The position of the right slider.")>
    Public Property ValueRight() As Integer
        Get
            Return _ValueRight
        End Get
        Set(ByVal value As Integer)
            If value < Me.Minimum OrElse value > Me.Maximum Then
                Throw New ArgumentException(String.Format("Value of '{0}' is not valid for 'ValueRight'. 'ValueRight' should be between 'Minimum' and 'Maximum'.", value.ToString()), "ValueRight")
            End If
            If value < Me.ValueLeft Then
                Throw New ArgumentException(String.Format("Value of '{0}' is not valid for 'ValueRight'. 'ValueRight' should be greater than or equal to 'ValueLeft'.", value.ToString()), "ValueLeft")
            End If
            _ValueRight = value

            Me.OnValueChanged(EventArgs.Empty)
            Me.OnRightValueChanged(EventArgs.Empty)

            Me.Invalidate()
        End Set
    End Property

    Private _Minimum As Integer
    ''' <summary>
    ''' Gets or sets the minimum value.
    ''' </summary>
    ''' <returns>The minimum value.</returns>
    <Description("The minimum value.")>
    Public Property Minimum() As Integer
        Get
            Return _Minimum
        End Get
        Set(ByVal value As Integer)
            If value >= Me.Maximum Then
                Throw New ArgumentException(String.Format("Value of '{0}' is not valid for 'Minimum'. 'Minimum' should be less than 'Maximum'.", value.ToString()), "Minimum")
            End If
            _Minimum = value
            Me.Invalidate()
        End Set
    End Property

    Private _Maximum As Integer
    ''' <summary>
    ''' Gets or sets the maximum value.
    ''' </summary>
    ''' <returns>The maximum value.</returns>
    <Description("The maximum value.")>
    Public Property Maximum() As Integer
        Get
            Return _Maximum
        End Get
        Set(ByVal value As Integer)
            If value <= Me.Minimum Then
                Throw New ArgumentException(String.Format("Value of '{0}' is not valid for 'Maximum'. 'Maximum' should be greater than 'Minimum'.", value.ToString()), "Maximum")
            End If
            _Maximum = value
            Me.Invalidate()
        End Set
    End Property

    Private _Orientation As Orientation
    ''' <summary>
    ''' Gets or sets the orientation of the control.
    ''' </summary>
    ''' <returns>The orientation of the control.</returns>
    <Description("The orientation of the control.")>
    Public Property Orientation() As Orientation
        Get
            Return _Orientation
        End Get
        Set(ByVal value As Orientation)
            _Orientation = value
        End Set
    End Property

    Private _SmallChange As Integer
    ''' <summary>
    ''' Gets or sets the amount of positions the closest slider moves when the control is clicked.
    ''' </summary>
    ''' <returns>The amount of positions the closest slider moves when the control is clicked.</returns>
    <Description("The amount of positions the closest slider moves when the control is clicked.")>
    Public Property SmallChange() As Integer
        Get
            Return _SmallChange
        End Get
        Set(ByVal value As Integer)
            _SmallChange = value
        End Set
    End Property

    Private ReadOnly Property RelativeValueLeft() As Double
        Get
            Dim diff As Double = Me.Maximum - Me.Minimum
            Return If(diff = 0, Me.ValueLeft, Me.ValueLeft / diff)
        End Get
    End Property

    Private ReadOnly Property RelativeValueRight() As Double
        Get
            Dim diff As Double = Me.Maximum - Me.Minimum
            Return If(diff = 0, Me.ValueLeft, Me.ValueRight / diff)
        End Get
    End Property

#End Region

#Region " Methods "

    Public Sub IncrementLeft()
        Dim newValue As Integer = Math.Min(Me.ValueLeft + 1, Me.Maximum)
        If Me.IsValidValueLeft(newValue) Then
            Me.ValueLeft = newValue
        End If
        Me.Invalidate()
    End Sub

    Public Sub IncrementRight()
        Dim newValue As Integer = Math.Min(Me.ValueRight + 1, Me.Maximum)
        If Me.IsValidValueRight(newValue) Then
            Me.ValueRight = newValue
        End If
        Me.Invalidate()
    End Sub

    Public Sub DecrementLeft()
        Dim newValue As Integer = Math.Max(Me.ValueLeft - 1, Me.Minimum)
        If Me.IsValidValueLeft(newValue) Then
            Me.ValueLeft = newValue
        End If
        Me.Invalidate()
    End Sub

    Public Sub DecrementRight()
        Dim newValue As Integer = Math.Max(Me.ValueRight - 1, Me.Minimum)
        If Me.IsValidValueRight(newValue) Then
            Me.ValueRight = newValue
        End If
        Me.Invalidate()
    End Sub

    Private Function IsValidValueLeft(ByVal value As Integer) As Boolean
        Return (value >= Me.Minimum AndAlso value <= Me.Maximum AndAlso value < Me.ValueRight)
    End Function

    Private Function IsValidValueRight(ByVal value As Integer) As Boolean
        Return (value >= Me.Minimum AndAlso value <= Me.Maximum AndAlso value > Me.ValueLeft)
    End Function

    Private Function GetLeftThumbRectangle(Optional ByVal g As Graphics = Nothing) As Rectangle
        Dim shouldDispose As Boolean = (g Is Nothing)
        If shouldDispose Then g = Me.CreateGraphics()

        Dim rect As Rectangle = Me.GetThumbRectangle(Me.RelativeValueLeft, g)
        If shouldDispose Then g.Dispose()

        Return rect
    End Function

    Private Function GetRightThumbRectangle(Optional ByVal g As Graphics = Nothing) As Rectangle
        Dim shouldDispose As Boolean = (g Is Nothing)
        If shouldDispose Then g = Me.CreateGraphics()

        Dim rect As Rectangle = Me.GetThumbRectangle(Me.RelativeValueRight, g)
        If shouldDispose Then g.Dispose()

        Return rect
    End Function

    Private Function GetThumbRectangle(ByVal relativeValue As Double, ByVal g As Graphics) As Rectangle
        Dim size As Size = TrackBarRenderer.GetBottomPointingThumbSize(g, VisualStyles.TrackBarThumbState.Normal)
        Dim border As Integer = CInt(size.Width / 2)
        Dim w As Integer = Me.GetTrackRectangle(border).Width
        Dim x As Integer = CInt(Math.Abs(Me.Minimum) / (Me.Maximum - Me.Minimum) * w + relativeValue * w)

        Dim y As Integer = CInt((Me.Height - size.Height) / 2)
        Return New Rectangle(New Point(x, y), size)
    End Function

    Private Function GetTrackRectangle(ByVal border As Integer) As Rectangle
        'TODO: Select Case for hor/ver
        Return New Rectangle(border, CInt(Me.Height / 2) - 3, Me.Width - 2 * border - 1, 4)
    End Function

    Private Function GetClosestSlider(ByVal point As Point) As Thumbs
        Dim leftThumbRect As Rectangle = Me.GetLeftThumbRectangle()
        Dim rightThumbRect As Rectangle = Me.GetRightThumbRectangle()
        If Me.Orientation = Windows.Forms.Orientation.Horizontal Then
            If Math.Abs(leftThumbRect.X - point.X) > Math.Abs(rightThumbRect.X - point.X) _
            AndAlso Math.Abs(leftThumbRect.Right - point.X) > Math.Abs(rightThumbRect.Right - point.X) Then
                Return Thumbs.Right
            Else
                Return Thumbs.Left
            End If
        Else
            If Math.Abs(leftThumbRect.Y - point.Y) > Math.Abs(rightThumbRect.Y - point.Y) _
            AndAlso Math.Abs(leftThumbRect.Bottom - point.Y) > Math.Abs(rightThumbRect.Bottom - point.Y) Then
                Return Thumbs.Right
            Else
                Return Thumbs.Left
            End If
        End If
    End Function

    Private Sub SetThumbState(ByVal location As Point, ByVal newState As VisualStyles.TrackBarThumbState)
        Dim leftThumbRect As Rectangle = Me.GetLeftThumbRectangle()
        Dim rightThumbRect As Rectangle = Me.GetRightThumbRectangle()

        If leftThumbRect.Contains(location) Then
            leftThumbState = newState
        Else
            If Me.SelectedThumb = Thumbs.Left Then
                leftThumbState = VisualStyles.TrackBarThumbState.Hot
            Else
                leftThumbState = VisualStyles.TrackBarThumbState.Normal
            End If
        End If

        If rightThumbRect.Contains(location) Then
            rightThumbState = newState
        Else
            If Me.SelectedThumb = Thumbs.Right Then
                rightThumbState = VisualStyles.TrackBarThumbState.Hot
            Else
                rightThumbState = VisualStyles.TrackBarThumbState.Normal
            End If
        End If
    End Sub

    Protected Overrides Sub OnMouseMove(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseMove(e)
        Me.SetThumbState(e.Location, VisualStyles.TrackBarThumbState.Hot)

        Dim offset As Integer = CInt(e.Location.X / (Me.Width) * (Me.Maximum - Me.Minimum))
        Dim newValue As Integer = Me.Minimum + offset
        If draggingLeft Then
            If Me.IsValidValueLeft(newValue) Then Me.ValueLeft = newValue
        ElseIf draggingRight Then
            If Me.IsValidValueRight(newValue) Then Me.ValueRight = newValue
        End If

        Me.Invalidate()
    End Sub

    Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseDown(e)
        Me.Focus()
        Me.SetThumbState(e.Location, VisualStyles.TrackBarThumbState.Pressed)

        draggingLeft = (leftThumbState = VisualStyles.TrackBarThumbState.Pressed)
        If Not draggingLeft Then draggingRight = (rightThumbState = VisualStyles.TrackBarThumbState.Pressed)

        If draggingLeft Then
            Me.SelectedThumb = Thumbs.Left
        ElseIf draggingRight Then
            Me.SelectedThumb = Thumbs.Right
        End If

        If Not draggingLeft AndAlso Not draggingRight Then
            If Me.GetClosestSlider(e.Location) = 1 Then
                If e.X < Me.GetLeftThumbRectangle().X Then
                    Me.DecrementLeft()
                Else
                    Me.IncrementLeft()
                End If
                Me.SelectedThumb = Thumbs.Left
            Else
                If e.X < Me.GetRightThumbRectangle().X Then
                    Me.DecrementRight()
                Else
                    Me.IncrementRight()
                End If
                Me.SelectedThumb = Thumbs.Right
            End If
        End If

        Me.Invalidate()
    End Sub

    Protected Overrides Sub OnMouseUp(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseUp(e)
        draggingLeft = False
        draggingRight = False
        Me.Invalidate()
    End Sub

    Protected Overrides Sub OnMouseWheel(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseWheel(e)

        If e.Delta = 0 Then Return

        If Me.SelectedThumb = 1 Then
            If e.Delta > 0 Then
                Me.IncrementLeft()
            Else
                Me.DecrementLeft()
            End If
        ElseIf Me.SelectedThumb = 2 Then
            If e.Delta > 0 Then
                Me.IncrementRight()
            Else
                Me.DecrementRight()
            End If
        End If
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)

        Dim thumbSize As Size = Me.GetThumbRectangle(0, e.Graphics).Size
        Dim trackRect As Rectangle = Me.GetTrackRectangle(CInt(thumbSize.Width / 2))
        Dim ticksRect As Rectangle = trackRect
        ticksRect.Offset(0, -15) 'changed to -15 to place ticks at the top

        'added this to keep ticks at a decent spacing
        Dim tickspacing As Integer = CInt((Me.Maximum - Me.Minimum) / 10) + 1

        TrackBarRenderer.DrawHorizontalTrack(e.Graphics, trackRect)
        TrackBarRenderer.DrawHorizontalTicks(e.Graphics, ticksRect, tickspacing, VisualStyles.EdgeStyle.Etched)

        'Changed these to draw the top pointing thumb button
        TrackBarRenderer.DrawTopPointingThumb(e.Graphics, Me.GetLeftThumbRectangle(e.Graphics), leftThumbState)
        TrackBarRenderer.DrawTopPointingThumb(e.Graphics, Me.GetRightThumbRectangle(e.Graphics), rightThumbState)
    End Sub

#End Region

#Region " Events "

    Public Event ValueChanged As EventHandler
    Public Event LeftValueChanged As EventHandler
    Public Event RightValueChanged As EventHandler

    Protected Overridable Sub OnValueChanged(ByVal e As EventArgs)
        RaiseEvent ValueChanged(Me, e)
    End Sub

    Protected Overridable Sub OnLeftValueChanged(ByVal e As EventArgs)
        RaiseEvent LeftValueChanged(Me, e)
    End Sub

    Protected Overridable Sub OnRightValueChanged(ByVal e As EventArgs)
        RaiseEvent RightValueChanged(Me, e)
    End Sub

#End Region

End Class