   M S B A M L   `   `   `  ����E  AOODProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:OODProject
OODProject  5   	       OODProject.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:OODProject     5   	   U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
   -   5          � Title$  
MainWindow��5	   	   $	��500��6   $	��300��6)    � 
ResizeMode$ NoResize=�6L    � WindowStartupLocation$ CenterScreen=�6b    � 	Resources 5         ListBoxMusic �� Orientation A�Name �� ImageSource��%�   &	        �� 5   
   .R�5      �� $ 
Horizontal=�6   .+�5      A� $ ArtistImage��6   $
��20,0q�6/   $��20��6=   $��Center=�6I   ��5      �� 5      $ Assets/Pic2.jpg��6%   5      5      5      5       .��5"      � 
���   �.+�5#   
   � $	��Top=�6   $��10q�6(   .+�5$      �� $
��Left=�6   $��20��60   $��20��6;   $
��10,5q�6G    0 ,MaterialDesignFloatingActionMiniAccentButton#��[ 6U   $	��Top=�6�   ��6�   Z� ��6�   Z� .��5%      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Plus=�6*   $��20��66   $��20��6A   $��Center=�6M   $��Center=�6j   ��5&      �� 5'       �� EndPoint$ 0.5,1&�6.   	 � MappingMode$	 RelativeToBoundingBox=�6?   
 �� 
StartPoint$
 0.5,0&�6c   .��5(      �  � Color$ 	#FFD69016��6+   � 5)      $ 	#FFD6511E��6+    � Offset$ 0.747Q�6=   � 5*      $ 	#FF9B330D��6+   $ 0.747Q�6=   5+      5-      5.      �� 5/      .+�50      �� $��Tocando Agora��6   $��Center=�61   
����İ�6N   �� 51      $$��Witt Lowry - Around Your Heart��6   $��Center=�6B   
����İ�6_   52      �� 53      $��Right=�6   $��20��61   $��20��6<   $
��10,5q�6H   #��[ 6V   $	��Top=�6�   ��6�   Z� ��6�   Z� .��54        $ Power=�6*   $��20��67   $��20��6B   $��Center=�6N   $��Center=�6k   ��55      �� 56      $ 0.5,1&�6.   $	 RelativeToBoundingBox=�6?   $
 0.5,0&�6c   .��57      � $ 	#FFD69016��6+   � 58      $ 	#FFD6511E��6+   $ 0.747Q�6=   � 59      $ 	#FF9B330D��6+   $ 0.747Q�6=   5:      5<      5=      5>      � 5?   
   $��10q�6   ���	#44444444$	��300��62   $	��Top=�6?   .+�5@      A� $��1��6   $��83,60,73,119q�6*   ��5A      �� 5B      $ 0.5,1&�6*   $
 0.5,0&�6;   .��5C      � $ Black��6'   $
 0.71Q�65   � 5D      $ 	#FFB85219��6'   � 5E      $ 	#FEB14F18��6'   $
 0.60Q�69   5F      5I      A� 5J      $��85,62,75,121q�6   ��5K      �� 5L      $ 0.5,1&�6*   $
 0.5,0&�6;   .��5M      � $ 	#FF0C0604��6'   $ 1Q�69   � 5N      $ 	#FF210900��6'   $ 0.047Q�69   � 5O      $ 	#FF1D0800��6'   $ 0.602Q�69   5P      5R      A� 5S      -   5        $��artistImage��5S      $��89,66,79,125q�6)   ��5T      �� 5U      $ Assets/unnamed.jpg��6!    j� Stretch$ UniformToFill=�6B   5W      A� 5X      ���	#66000000$��89,66,79,125q�6'   � 5Y      $��Bottom=�6   $��5q�6.   .+�5Z      �� $
��Left=�6   $��20��64   $��20��6?   $
��10,5q�6K   #��[ 6Y   $��Center=�6�   ��6�   Z� ��6�   Z� .��5[        $ RotateRight=�6.   $��20��6A   $��20��6L   ��5\      �� 5]      $ 0.5,1&�62   $	 RelativeToBoundingBox=�6C   $
 0.5,0&�6g   .��5^   "   � $ 	#FFD69016��6/   � 5_   "   $ 	#FFD6511E��6/   $ 0.747Q�6A   � 5`   "   $ 	#FF9B330D��6/   $ 0.747Q�6A   5a      5c      5d      �� 5e      $
��Left=�6   $��20��64   $��20��6?   $
��50,5q�6K   #��[ 6Y   $��Center=�6�   ��6�   Z� ��6�   Z� .��5f        $ ChevronLeft=�6.   $��20��6A   $��20��6L   ��5g      �� 5h      $ 0.5,1&�62   $	 RelativeToBoundingBox=�6C   $
 0.5,0&�6g   .��5i   "   � $ 	#FFD69016��6/   � 5j   "   $ 	#FFD6511E��6/   $ 0.747Q�6A   � 5k   "   $ 	#FF9B330D��6/   $ 0.747Q�6A   5l      5n      5o      �� 5q      -   5         ��Name$ BtnPlay��5q      $��Center=�6*   $��Center=�6G   #��[ 6b   ���	#70702222���	#B2222222 J� Effect 5r      3  -System.Windows.Media.Effects.DropShadowEffect  5s         
BlurRadius$ 20Q�6+      Color$ 	#FFD67619��6;      	Direction$ -0Q�6M      RenderingBias$ Quality=�6\      ShadowDepth$ 1Q�6t   .��5u        $ Pause=�6.   $��30��6;   $��30��6F   ��5v      �� 5w      $	 RelativeToBoundingBox=�62   $ 0.5,1&�6V   .��5x   "   � $ 	#FFD69016��6/   � 5y   "   $ 	#FFD6511E��6/   $ 0.747Q�6A   � 5z   "   $ 	#FF9B330D��6/   $ 0.747Q�6A   5{      5}      5~      �� 5�      $��Right=�6   $��20��66   $��20��6A   $
��50,5q�6M   #��[ 6[   $��Center=�6�   ��6�   Z� ��6�   Z� .��5�        $ ChevronRight=�6.   $��20��6B   $��20��6M   ��5�      �� 5�      $ 0.5,1&�62   $	 RelativeToBoundingBox=�6C   $
 0.5,0&�6g   .��5�   "   � $ 	#FFD69016��6/   � 5�   "   $ 	#FFD6511E��6/   $ 0.747Q�6A   � 5�   "   $ 	#FF9B330D��6/   $ 0.747Q�6A   5�      5�      5�      �� 5�      $��Right=�6   $��20��65   $��20��6@   $
��10,5q�6L   #��[ 6Z   $��Center=�6�   ��6�   Z� ��6�   Z� .��5�        $ Shuffle=�6.   $��20��6=   $��20��6H   ��5�      �� 5�      $ 0.5,1&�62   $	 RelativeToBoundingBox=�6C   $
 0.5,0&�6g   .��5�   "   � $ 	#FFD69016��6/   � 5�   "   $ 	#FFD6511E��6/   $ 0.747Q�6A   � 5�   "   $ 	#FF9B330D��6/   $ 0.747Q�6A   5�      5�      5�      5�      �� 5�      -   5         ��Name$ TblkArtistName��5�      $
��Left=�60   $��
72,218,0,0q�6K   $
��Wrap=�6_   $	��Top=�6s   $	��135��6�   $��17��6�    �� TextAlignment$ Center=�6�   $��
ArtistName��6�   ���	#FFE3EAD86�   5�      �� 5�   
   -   5        $ BtnCycleRight��5�      $��Right=�6)   $��20��6E   $��20��6P   $
��50,5q�6\   #��[ 6j   $��Center=�6�   ��6�   Z� ��6�   Z� .��5�        $ ChevronRight=�6&   $��20��6:   $��20��6E   ��5�      �� 5�      $ 0.5,1&�6*   $	 RelativeToBoundingBox=�6;   $
 0.5,0&�6_   .��5�      � $ 	#FFD69016��6'   � 5�      $ 	#FFD6511E��6'   $ 0.747Q�69   � 5�      $ 	#FF9B330D��6'   $ 0.747Q�69   5�      5�      5�      �� 5�   
   -   5        $ BtnCycleLeft��5�      $
��Left=�6'   $��20��6B   $��20��6M   $
��50,5q�6Y   #��[ 6g   $��Center=�6�   ��6�   Z� ��6�   Z� .��5�        $ ChevronLeft=�6&   $��20��69   $��20��6D   ��5�      �� 5�      $ 0.5,1&�6*   $	 RelativeToBoundingBox=�6;   $
 0.5,0&�6_   .��5�      � $ 	#FFD69016��6'   � 5�      $ 	#FFD6511E��6'   $ 0.747Q�69   � 5�      $ 	#FF9B330D��6'   $ 0.747Q�69   5�      5�      5�      �� 5�   
   -   5         ��Name$
 test��5�      $
��Left=�6    $	��133��6;   $��
10,328,0,0q�6H   $	��Top=�6\   $	��274��6t   ���	#DDFFFFFF6�   5�      5�      