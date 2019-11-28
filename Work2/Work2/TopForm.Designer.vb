<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TopForm
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ymBox = New ymdBox.ymdBox()
        Me.rbtnHead = New System.Windows.Forms.RadioButton()
        Me.rbtnHelper = New System.Windows.Forms.RadioButton()
        Me.rbtnSanato = New System.Windows.Forms.RadioButton()
        Me.rbtnNurse = New System.Windows.Forms.RadioButton()
        Me.rbtnByoto = New System.Windows.Forms.RadioButton()
        Me.dgvWork = New Work2.WorkDataGridView(Me.components)
        CType(Me.dgvWork, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ymBox
        '
        Me.ymBox.boxType = 7
        Me.ymBox.DateText = ""
        Me.ymBox.EraLabelText = "R01"
        Me.ymBox.EraText = ""
        Me.ymBox.Location = New System.Drawing.Point(26, 21)
        Me.ymBox.MonthLabelText = "11"
        Me.ymBox.MonthText = ""
        Me.ymBox.Name = "ymBox"
        Me.ymBox.Size = New System.Drawing.Size(120, 46)
        Me.ymBox.TabIndex = 0
        Me.ymBox.textReadOnly = False
        '
        'rbtnHead
        '
        Me.rbtnHead.AutoSize = True
        Me.rbtnHead.Location = New System.Drawing.Point(240, 45)
        Me.rbtnHead.Name = "rbtnHead"
        Me.rbtnHead.Size = New System.Drawing.Size(47, 16)
        Me.rbtnHead.TabIndex = 10
        Me.rbtnHead.TabStop = True
        Me.rbtnHead.Text = "師長"
        Me.rbtnHead.UseVisualStyleBackColor = True
        '
        'rbtnHelper
        '
        Me.rbtnHelper.AutoSize = True
        Me.rbtnHelper.Location = New System.Drawing.Point(240, 21)
        Me.rbtnHelper.Name = "rbtnHelper"
        Me.rbtnHelper.Size = New System.Drawing.Size(47, 16)
        Me.rbtnHelper.TabIndex = 9
        Me.rbtnHelper.TabStop = True
        Me.rbtnHelper.Text = "助手"
        Me.rbtnHelper.UseVisualStyleBackColor = True
        '
        'rbtnSanato
        '
        Me.rbtnSanato.AutoSize = True
        Me.rbtnSanato.Location = New System.Drawing.Point(171, 45)
        Me.rbtnSanato.Name = "rbtnSanato"
        Me.rbtnSanato.Size = New System.Drawing.Size(47, 16)
        Me.rbtnSanato.TabIndex = 8
        Me.rbtnSanato.TabStop = True
        Me.rbtnSanato.Text = "療養"
        Me.rbtnSanato.UseVisualStyleBackColor = True
        '
        'rbtnNurse
        '
        Me.rbtnNurse.AutoSize = True
        Me.rbtnNurse.Location = New System.Drawing.Point(171, 21)
        Me.rbtnNurse.Name = "rbtnNurse"
        Me.rbtnNurse.Size = New System.Drawing.Size(47, 16)
        Me.rbtnNurse.TabIndex = 7
        Me.rbtnNurse.TabStop = True
        Me.rbtnNurse.Text = "一般"
        Me.rbtnNurse.UseVisualStyleBackColor = True
        '
        'rbtnByoto
        '
        Me.rbtnByoto.AutoSize = True
        Me.rbtnByoto.Location = New System.Drawing.Point(309, 21)
        Me.rbtnByoto.Name = "rbtnByoto"
        Me.rbtnByoto.Size = New System.Drawing.Size(47, 16)
        Me.rbtnByoto.TabIndex = 11
        Me.rbtnByoto.TabStop = True
        Me.rbtnByoto.Text = "病棟"
        Me.rbtnByoto.UseVisualStyleBackColor = True
        Me.rbtnByoto.Visible = False
        '
        'dgvWork
        '
        Me.dgvWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvWork.Location = New System.Drawing.Point(26, 84)
        Me.dgvWork.Name = "dgvWork"
        Me.dgvWork.RowTemplate.Height = 21
        Me.dgvWork.Size = New System.Drawing.Size(1257, 517)
        Me.dgvWork.TabIndex = 1
        '
        'TopForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1316, 623)
        Me.Controls.Add(Me.rbtnByoto)
        Me.Controls.Add(Me.rbtnHead)
        Me.Controls.Add(Me.rbtnHelper)
        Me.Controls.Add(Me.rbtnSanato)
        Me.Controls.Add(Me.rbtnNurse)
        Me.Controls.Add(Me.dgvWork)
        Me.Controls.Add(Me.ymBox)
        Me.Name = "TopForm"
        Me.Text = "勤務割"
        CType(Me.dgvWork, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ymBox As ymdBox.ymdBox
    Friend WithEvents dgvWork As Work2.WorkDataGridView
    Friend WithEvents rbtnHead As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnHelper As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnSanato As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnNurse As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnByoto As System.Windows.Forms.RadioButton

End Class
