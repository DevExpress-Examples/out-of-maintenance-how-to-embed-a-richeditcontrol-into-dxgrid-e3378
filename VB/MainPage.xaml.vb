Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Net
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes
Imports System.Xml.Serialization
Imports System.Reflection

Namespace DXSample
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
			grid.ItemsSource = CarsData.ItemsSource
		End Sub
	End Class

	<XmlRoot("NewDataSet")> _
	Public Class CarsData
		Inherits List(Of Cars)
		Public Shared ReadOnly Property ItemsSource() As IList(Of Cars)
			Get

				Dim s As New XmlSerializer(GetType(CarsData))
				Return CType(s.Deserialize(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("Cars2.xml")), List(Of Cars))
			End Get
		End Property
	End Class

	Public Class Cars
		Private privateID As Integer
		Public Property ID() As Integer
			Get
				Return privateID
			End Get
			Set(ByVal value As Integer)
				privateID = value
			End Set
		End Property
		Private privateTrademark As String
		Public Property Trademark() As String
			Get
				Return privateTrademark
			End Get
			Set(ByVal value As String)
				privateTrademark = value
			End Set
		End Property
		Private privateModel As String
		Public Property Model() As String
			Get
				Return privateModel
			End Get
			Set(ByVal value As String)
				privateModel = value
			End Set
		End Property
		Private privateHP As Integer
		Public Property HP() As Integer
			Get
				Return privateHP
			End Get
			Set(ByVal value As Integer)
				privateHP = value
			End Set
		End Property
		Private privateLiter As Double
		Public Property Liter() As Double
			Get
				Return privateLiter
			End Get
			Set(ByVal value As Double)
				privateLiter = value
			End Set
		End Property
		Private privateCyl As Integer
		Public Property Cyl() As Integer
			Get
				Return privateCyl
			End Get
			Set(ByVal value As Integer)
				privateCyl = value
			End Set
		End Property
		Private privateTransmissSpeedCount As Integer
		Public Property TransmissSpeedCount() As Integer
			Get
				Return privateTransmissSpeedCount
			End Get
			Set(ByVal value As Integer)
				privateTransmissSpeedCount = value
			End Set
		End Property
		Private privateTransmissAutomatic As String
		Public Property TransmissAutomatic() As String
			Get
				Return privateTransmissAutomatic
			End Get
			Set(ByVal value As String)
				privateTransmissAutomatic = value
			End Set
		End Property
		Private privateMPG_City As Integer
		Public Property MPG_City() As Integer
			Get
				Return privateMPG_City
			End Get
			Set(ByVal value As Integer)
				privateMPG_City = value
			End Set
		End Property
		Private privateMPG_Highway As Integer
		Public Property MPG_Highway() As Integer
			Get
				Return privateMPG_Highway
			End Get
			Set(ByVal value As Integer)
				privateMPG_Highway = value
			End Set
		End Property
		Private privateCategory As String
		Public Property Category() As String
			Get
				Return privateCategory
			End Get
			Set(ByVal value As String)
				privateCategory = value
			End Set
		End Property
		Private privateDescription As String
		Public Property Description() As String
			Get
				Return privateDescription
			End Get
			Set(ByVal value As String)
				privateDescription = value
			End Set
		End Property
		Private privateHyperlink As String
		Public Property Hyperlink() As String
			Get
				Return privateHyperlink
			End Get
			Set(ByVal value As String)
				privateHyperlink = value
			End Set
		End Property
		Private privatePicture As Byte()
		Public Property Picture() As Byte()
			Get
				Return privatePicture
			End Get
			Set(ByVal value As Byte())
				privatePicture = value
			End Set
		End Property
		Private privatePrice As Decimal
		Public Property Price() As Decimal
			Get
				Return privatePrice
			End Get
			Set(ByVal value As Decimal)
				privatePrice = value
			End Set
		End Property
		Private privateRtfContent As String
		Public Property RtfContent() As String
			Get
				Return privateRtfContent
			End Get
			Set(ByVal value As String)
				privateRtfContent = value
			End Set
		End Property
	End Class
End Namespace
