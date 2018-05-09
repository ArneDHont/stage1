Imports System.Drawing

Public Class ImageResizer

    Public Shared Sub resizeImage(ByVal pathImage As String, ByRef pathBijlageResized As String)
        'Siddien - 28/12/2006 - tijdens het versturen naar bestemmelingen moeten de foto's verkleind worden.
        Try


            ' Get the scale factor.
            Dim scale_factor As Single = 0.5

            ' Get the source bitmap.
            Dim bm_source As New Bitmap(pathImage)

            ' Make a bitmap for the result.
            Dim bm_dest As New Bitmap( _
                CInt(bm_source.Width * scale_factor), _
                CInt(bm_source.Height * scale_factor))



            ' Make a Graphics object for the result Bitmap.
            Dim gr_dest As Graphics = Graphics.FromImage(bm_dest)

            ' Copy the source image into the destination bitmap.
            gr_dest.DrawImage(bm_source, 0, 0, _
                bm_dest.Width + 1, _
                bm_dest.Height + 1)

            pathBijlageResized = pathImage.Insert(pathImage.LastIndexOf("."), "small")
            bm_dest.Save(pathBijlageResized, Imaging.ImageFormat.Jpeg)

        Catch ex As Exception
            Throw
        End Try
    End Sub
End Class
