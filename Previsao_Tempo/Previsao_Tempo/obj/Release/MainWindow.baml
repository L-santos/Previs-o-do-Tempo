   M S B A M L   `   `   `  ����   Previsao_Tempo    Previsao_Tempo.MainWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006       � Title$  Previsão do Tempo��$��486.851��$��435.381�� � 
ResizeMode$ CanMinimize=� � Icon$ Assets/clouds.png�� � 	Resources    ListViewTemplate � ColumnDefinitions��%�  &	        �� .R�� $��91��$	��300�� �� $��9* ��� $	��16* �.+��� $
��Left=�$��91��$	��Top=�$	��108��$��0������ *imagem+�� $��1��.+��� ���� *data+�� $��1��$��1������ *	descricao+�� $��1��$��1��$��Min: ���� ��� *temperatura_min+ �� $�°���� $��1��$��1��$��Max: ���� ��� *temperatura_max+ �� $�°��.��� .+�� -    �Name$ 
SearchGrid��$y�Visible=� � RowDefinitions �� $	��13* ��� $
��445* �����  �� ImageSource$ Assets/weather.png�� j� Stretch$ UniformToFill=�.+��� $	��216��$	��106��$��Center=�$	��Top=�$��1��.+��� $��15(�$��Cidade���� -   	 ��Name$	 	txtCidade���� $��15(�$��Estado (opcional)���� -   $	 	txtEstado���� -   $��26��$��58��$��Center=�$��Center=�$��Buscar��� -   $��progress��$��Center=�$��8��$��1��$��Center=�$	��169��
 � IsIndeterminate
 . $y�Hidden=����	#FF4482B39� $
��Info�� 9� 
IsExpanded .  $
��Left=�$	��169��$��
10,266,0,0q�$��1��$	��Top=�$	��364�� 9� ExpandDirection$ Up=�.���� ���	#FF66A6CE$	��126��$��0,0,19,0q�.+���  �� TextAlignment$ Center=�$��Italic$�$��14(�$
��Bold"�$"Previsão do Tempo by Lucas Santos�� $��	Underline{�(&API Previsão do Tempo Agencia Ideias:�� .,http://developers.agenciaideias.com.br/tempo�� �� 
���  ��%#NOTE: For educational purposes only�� -   $��txtErro��$�� ��$
��Left=�$��106,111,0,0q�$��1��$
��Wrap=�$	��Top=�$	��216��
���  ��$��14(�$
��Bold"�$y�Hidden=�� -   $ 
ResultGrid��$y�	Collapsed=�$��1������ $ Assets/weather.png�� �� $
��116* ��� $
��313* � �� $	��15* ��� $	��50* ��� $
��163* �.+��� $��20(�$��Center=�$	��Top=�$ Justify=�$	��213��$��27��$��1������ *Nome+�� $
��Left=�$��90��$	��Top=�$	��115��$��0,10,0,0q�$��2������ *Imagem+�� $��1��$��
0,0,162,77q�$��1������ *	Descricao+�� $��Assets/Thermo.png��$��182,10,112,77q� J� RenderTransformOrigin$ 6.312,1.533&�$��1��$��1���� $��1��$ Justify=�$��206,0,50,68q�$��1��$��22(����� *Temperatura+�� $��1��$��0,29,162,53q�$��1������ *
Humidade+�� $��0,48,139,34q�$��1��$��1���� $�Velocidade do vento: �� �� ��� *	Vento_Vel+ �� $
�Km/h���� $��0,67,139,15q�$��1��$��1���� $�Direção do vento: ���� ��� *	Vento_Dir+�� -   $��1��$��
236,75,9,5q�$��1��.��Voltar�� -	    ��Name$
 list��$��2��$��2��#���   ���� ���� $ Assets/weather.png��