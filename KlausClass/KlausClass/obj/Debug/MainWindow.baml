   M S B A M L   `   `   `  ����E  AKlausClass, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:KlausClass
KlausClass  5   	       KlausClass.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:KlausClass     5   	   -   5          �Name$  Title��5   	    � Title$ 
MainWindow��5   	   $	��380��6   $	��600��6(   $	��380��65   $	��600��6D    � 	Resources 5	         FadeEffect_In �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value��%W  &	        �� 5
   
   .��5      U� $ (UIElement.Opacity)�6,   $ ellipse��6\   .\�5        $ 0:0:0.8��6'   $ 1Q�69   5      U� 5      $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�6,   $ ellipse��6�   .\�5        $ 0:0:0.8��6'   $	 -75Q�69   5      5      5       � Triggers 5      :� 5   
    :� RoutedEvent$ UIElement.MouseEnter��6   	 :� 
SourceName$	 ellipse��6:   .[�5      �� -   5        
 ��Name$#
 FadeEffect_In_BeginStoryboard��5      #��[  6E   5      :� 5   
   $ UIElement.MouseLeave��6   $	 ellipse��6:   .[�5      ��  �� BeginStoryboardName$# FadeEffect_In_BeginStoryboard��6   5      ��5      �� 5   
    �� ImageSource$ 945863297e8cb1c.jpg��6   .��5      � $��0q�6   $	��380��6   $	��600��6%    � ColumnDefinitions 5   
   �� 5       �� 5!      $	��120 �6   �� 5"       � RowDefinitions 5$   
   �� 5%      $��35 �6   �� 5&      $��3* �6   �� 5'      $	��120 �6   �� 5(      .+�5*   
   �� $��3��6   ���	#FFF4F4F5
������� J� Opacity$	 0.6Q�6H   A� 5+   
   $��1��6   ���	#FF09092C$��2��63   
������� K� ZIndex$ 5��6O   A� 5,   
   -   5         A�Name$ ellipse��5,      ���	#FF606064$��Right=�64   $��60��6P   $��64,260.4,-35,-35q�6\   $��1��6v   
���   �$��Bottom=�6�   $��60��6�    �� StrokeDashArray$	 1 3R�6�   $��2��6�    �� StrokeDashCap$ Round=�6�   $	 0.7Q�6�    J� RenderTransformOrigin$ 0.5,0.5&�6  z�5-      V� 5.      .~�5/      �� �� 50      �� 51      T� 52      53      55      A� 56   
   ���	#FF8181F0$
��Left=�6#   $��60��6>   $��2��6J   
�������$��Bottom=�6f   $��60��6�   $��1��6�   $��85,0,0,86.25q�6�   $��2��6�   $��2��6�   57      58      