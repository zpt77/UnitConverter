   M S B A M L   `   `   `  ���� P  LUnitConverter.Desktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:UnitConverter.DesktopUnitConverter.Desktop  c _Microsoft.Data.SqlClient, Version=2.0.20168.4, Culture=neutral, PublicKeyToken=23ec7fc2d6eaa4a5eHclr-namespace:Microsoft.Data.SqlClient;assembly=Microsoft.Data.SqlClientMicrosoft.Data.SqlClient &     UnitConverter.Desktop.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5local#clr-namespace:UnitConverter.Desktop     ^	SqlClientHclr-namespace:Microsoft.Data.SqlClient;assembly=Microsoft.Data.SqlClient       � Title$  	Konwerter��$	��360��$	��500��.��� -    �Name$
 grid�� � ColumnDefinitions �� �� .+��� $��0��$	��250��.+��� $��10,5,10,2.5q�$��11(�$��Miara konwersji:���� -    ��Name$ measureComboBox��$��10,2.5,10,5q��  �� �� .+��� $��0��$��
10,5,1,2.5q�$��Center=�$��11(�$��Jednostka wejściowa:���� -   $ inputUnitComboBox��$��1��$��5,2.5,10,2.5q�$��75��$��Right=��� $��0��$��10,2.5,10,2.5q�$��Center=�$��11(�$��Jednostka wyjściowa:���� -   $ outputUnitComboBox��$��1��$��10,2.5,10,5q�$��75��$��Center=��� $��0��$��10,5,10,2.5q�$��
Wartość:���� -    ��Name$ inputTextBox��$��1��$��10,2.5,10,5q��� -   $��	Konwertuj��$	��150���� $��10,5,10,2.5q�$��Wynik:���� -    ��Name$ outputTextBlock��$��	30,1,30,5q��� -   $��
Statystyki��$��20��$	��150���� $��1��$	��250��.+��� $��10q�
����  � �� CornerRadius$	 300��$	��200��$	��200��$��Center=�$��Center=�._�� $	��180��$	��180��.+��� $	 350��
����·��� -	    ��Name$
 hour��$ 	0 15 15 0��$��5��$��60��$��2q�
���   �$��90,88,30,88q� J� RenderTransformOrigin$ 0,0.383&�z�V� .~��� �� �� 	 �� Angle$		 -90Q�T� �� -
   $ minutes��$ 	0 15 15 0��$��3��$��85��$��2q�
�������$��
90,89,5,88q�$ 0.003,0.472&�z�V� -   tm��.~��� �� �� $		 -90Q�T� �� -   $ second��$ 	0 15 15 0��$��5��$��90��$��2q�
����  �$��
90,88,0,88q�$ 0,0.408&�z�V� -   transformGroup��.~��� �� �� $		 -90Q�T� A� 
����  �$��5��$��5��$��Center=�$��Center=�� -   $��pbStatus��$��10,20,10,2.5q�
 � Minimum$
 0Q� � Maximum$	 100Q�$��20��$	��180���� -   $��LoadingLabel��$��10,20,10,2.5q�$��Center=�$�� ��