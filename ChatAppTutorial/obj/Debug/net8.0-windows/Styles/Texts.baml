   M S B A M L   `   `   `  ����J  FChatAppTutorial, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ChatAppTutorialChatAppTutorial  5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089  �� 
TargetType   
HeaderText  BaseTextBlStyle �� BasedOn �� Property  ForegroundMainBrush �� Value  TextBox.MouseOver.Border �� Color  TextBox.Focus.Border  	BaseStyle  WordBlueBrush  FontSizeLarge  LatoRegular �� 
TargetType ��Name J� SnapsToDevicePixels ��Name	 ��Name
 J� IsHitTestVisible
 � Tag 	 LatoThin �� Padding 
 ForegroundDarkBrush �� Triggers �� Binding �� RelativeSource �� Value �� Triggers P� Property P� Value �� 
TargetName�� 5      F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml     5      'localclr-namespace:ChatAppTutorial  5      %S  &	        7  7  &	 �     &	 �     '��     7  7  7  7  7 	 7 
 7  7  �� 5      "  ��6   8   .�5   
   ��  � ��8  6'   �� 5   
    � ��$ Center=�6.   �� 5   
    � ��$ Center=�60   �� 5   
    � ��$	 0 4q�6#   5	      �� 5
      $ 	#FF7EB4EA��67   �� 5      $ 	#FF569DE5��63   �� 5      "  ��6   8   .�5   
   ��  � ��8  6(   �� 5   
    � ��8  6%   �� 5   
    � ��$ 10q�6$   �� 5   
    � ��$ 0 5 0 5q�6#   �� 5   
    � ��$ 0 0 0 1q�6,   �� 5   
    � ��8  6'   �� 5   
    � �� 5      �� 5      " ��6"   .R�5      � .+�5      �� $ border��6!   #��z��61   #��z��6[   #��z��6�   $
 True��6�   ._�5      �� $ PART_ContentHost��6+   $|�false��6E   $��Hidden=�6W   $��Hidden=�6~   5      �� 5      $	 placeholder��6Z   $
 False��6$   #��z 6=   8�� # z��6�   $��Center=�5   $   #��z��5   $   8�� ��5      �� 5    "   "  ��6(   .�5!   &   ��  � y�$ 	Collapsed=�6C    5"   &   �� 5#   *    66   �� *Text+ �� *TemplatedParent+  6   .a�5$   .   ��  � y�$ Visible=�6K   5%   +   5'   #   5)      5*       5,      P� 5-       � {�$ false��67   . �5.      �� $ border��68    �@J�Opacity$
 0.56Q�6L   5/      P� 50       �@J�IsMouseOver$
 true��69   . �51      �� $ border��6<   8   � ��6P   52      P� 53       �@J�IsKeyboardFocused$
 true��6?   . �54      �� $ border��6<   8   � ��6P   55      57      59      5:      5;      