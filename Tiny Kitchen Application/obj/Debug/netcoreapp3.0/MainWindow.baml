   M S B A M L   `   `   `  ����  Tiny Kitchen Application)    #Tiny_Kitchen_Application.MainWindow   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Aav2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        � Title$  Tiny Kitchen Application��5      $	��400��6$   $	��500��61   ���#3A6A59.��5      � $��0,0,-70,-89q�6    � 	Resources 5   
    �� 
TargetType �� Property �� Value��%Q   '��       �� 5      " ��6   .�5      ��  � ��$ 5q�6+   5      5       � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      $	��210 �6   �� 5      $	��100 �6   .+�5   
   �� -   5         ��Name$ Label1��5      $��Tiny Kitchen��5      $��70��5       $	��350��6    �� Left$ 10��5!      $��35(�5"      $��Verdana)�5#      $
��Bold"�5$      ���#D6C18A$	��Top=�5&      $
��Left=�5'      $��1��5(      $��0��6    $��3��5)      $��-7,0,0,0q�5*      �� 5-   
   -   5        	 ��Name$	 FindRecipeButton��5-      
�������$��95��5.   $   $��Verdana)�50      $��Find Recipe��51      $	��Top=�52      $��14(�53      $��Bottom=�54      $��	16,5,14,0q�63   $��1��6F   $��1��6V   �� 57   
   -   5        $	 RecipeCollectionButton��57      $��2��58      $��0��6!   
�������$	��102��59   $   $��Verdana)�5;      $��Collections��5<      $	��Top=�5=      $��14(�5>      $��Bottom=�5?      $��
17,98,12,0q�63   �� 5B   
   -   5        $	 PantryButton��5B      $��1��5C      
�������$��98��5D   $   $��Verdana)�5F      $��Pantry��5G      $	��Top=�5H      $��14(�5I      $��Bottom=�5J      $��
14,98,14,0q�63   �� 5L   
   -   5        $	 AddRecipeButton��5L      $��0��5M      
�������$	��110��5N       
 J� RenderTransformOrigin$
 0.5, 0.5&�5P      $��Verdana)�5Q      $	��Top=�5R      $��14(�5S      $��Bottom=�5T      $��17,157,10,0q�6/   $��2��6D   z�5U      V� 5V      .~�5W      ��  �� ScaleY$ 1Q�6%   �� 5X      �� 5Y      T� 5Z      5[      .��5]      �� $��
Add Recipe��6   5^      �� 5`   
   -   5        $	 CalendarButton��5`      $��2��5a      
�������$��93��5b   $   $��Verdana)�5c      $	��Top=�5e      $��14(�5f      $��Bottom=�5g      $��Calendar��5h      $��	15,7,12,0q�6$   $��1��67   �� 5j   
   $&�� Icon_Images/Find-Recipe-Icon.png��6   $��
34,3,34,14q�6:   $��1��6N   $��1��6^   �� 5k   
   $��Icon_Images/Add-icon.png��6   $��38,159,30,57q�62   $��2��6H   �� 5l   
   $!��Icon_Images/pantry-icon.png��6   $��1��65   $��31,93,26,25q�6E   �� 5m   
   $&�� Icon_Images/Collections-Icon.png��6   $��38,100,32,29q�6:   $��2��6P   �� 5n   
   $&�� /Time-And-Date-Calendar-icon.png��6    �� StretchDirection$
 Both=�6:   $��2��6R   $��	8,14,5,26q�6b   $
 0.5,0.5&�6u   $��1��6�   z�5o      V� 5p      .~�5q      �� $ 1Q�6%   �� 5r      �� 5s      T� 5t      5u      5w      5x      5|      