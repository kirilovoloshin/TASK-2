   M S B A M L   `   `   `  ????B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WpfApp1.HelperWpfApp1.Helper  5   	   -clr-namespace:WpfApp1.ModelWpfApp1.Model  5   	       WpfApp1.View.HelloWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   /helperclr-namespace:WpfApp1.Helper     5   	   -modelclr-namespace:WpfApp1.Model     5   	   -   5          ?Name$  Window??5	   	    ? Title$ HelloWindow??5
   	   $	??450??6   $	??800??6*    ? 	Resources 5      0   *WpfApp1.Helper.MultipleParametersConverter   MultipleConverter??%   &	          5   
   6I   5      .??5      ? ??5   
   ?? 5       ?? ImageSource$U O/View/1642242978_1-abrakadabra-fun-p-pole-dlya-krestikov-nolikov-bez-fona-1.jpg??6    ? RowDefinitions 5   
   ?? 5      $??* ?6   ?? 5      $??3* ?6    ? ColumnDefinitions 5   
   ?? 5      $??* ?6   ?? 5      $??* ?6   ?? 5      $??* ?6   .+?5   
   ??  ? DataContext 6   ?? 6+   ?? 5   
   $??1??6   $
??Left=?6   $	??Top=?68   $,??&За кого хочеш почати???5      $??20(?60   $??97??6>   $	??240??6J   $??Center=?6V   $??Center=?6z   $??	21,53,0,0q?6?   $??1??6?   
???   ?$
??Bold"?6?   ??5      ?? 5       ?? EndPoint$ 0.5,1&?6&    ?? 
StartPoint$ 0.5,0&?67   .??5       ? 	 ? Color$	 	#FFA5A2A2??6#   ? 5!      $	 White??6#   
 ? Offset$
 1Q?61   ? 5"      $	 	#FFD89A9A??6#   $
 0.499Q?65   5#      5%      ?? 5&   
   $	??108??6   $??98??6   $??1??6(   $??0??5'      $
??Left=?6    $	??Top=?5(      $??/Resources/cross.png??6(    ? Cursor$
 Hand??5)      $??
152,54,0,0q?6    J? InputBindings 5*      d? 5+       d? Gesture$ 	LeftClicka?6    ?? Command 63   ?? *ChooseSideCommand+ ?? CommandParameter 5,      `? 5-       `? 	Converter# [  6'   .1?5.      ??  ?? Path$ Cross?6&   ?? 5/       ?? ElementName$ Window??6&   50      52      54      ?? 56   
   $	??121??6   $??96??6   $??1??6(   $??2??65   $
??Left=?57      $	??Top=?6,   $??/Resources/zero.png??58      $
 Hand??6-   $??	31,57,0,0q?6;    59      d? 5:      $ 	LeftClicka?6    63   ?? *ChooseSideCommand+ 5;      `? 5<      # [  6'   .1?5=      ?? $
 Zero?6&   ?? 5>      $ Window??6&   5?      5A      5C      5D      5E      