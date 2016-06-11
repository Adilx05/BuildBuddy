using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;

namespace BuildBuddy
{
    
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private string BoS = "Buy";
        private string Item = 0.ToString();

        private void AddBt_OnClick(object sender, RoutedEventArgs e)
        {
           ListBoxItem esy = new ListBoxItem();
            esy.Content = ItemComboBox.Text + " : " + AoSComboBox.Text ;
            ListBox.Items.Add(esy);
            using (StreamWriter writer = new StreamWriter(ChampTxBx.Text + "-SummonersRift" + ".txt", true))
            {
                writer.Write(Item + ":" + BoS + ",");
            }
            //File.WriteAllText(ChampTxBx.Text + "-SummonersRift" + ".txt", Item + ":" + BoS + ",");
        }

       /* private void KaldirBt_OnClick(object sender, RoutedEventArgs e)
        {
            while (ListBox.SelectedItems.Count > 0)
            {
                var index = ListBox.Items.IndexOf(ListBox.SelectedItem);
                ListBox.Items.RemoveAt(index);
            }
            ListBox.Items.Refresh();
        }*/
#region itemler
        private void ListBoxItem_OnSelected(object sender, RoutedEventArgs e)
        {
            Item = 3001.ToString();
        }
        private void ListBoxItem2_OnSelected(object sender, RoutedEventArgs e)
        {
            Item = 3105.ToString();
        }
        private void LB4(object sender, RoutedEventArgs e)
        {
            Item = 3113.ToString();
        }
        private void LB5(object sender, RoutedEventArgs e)
        {
            Item = 1052.ToString();
        }
        private void LB6(object sender, RoutedEventArgs e)
        {
            Item = 3301.ToString();
        }
        private void LB7(object sender, RoutedEventArgs e)
        {
            Item = 3187.ToString();
        }
        private void LB8(object sender, RoutedEventArgs e)
        {
            Item = 3348.ToString();
        }
        private void LB9(object sender, RoutedEventArgs e)
        {
            Item = 3007.ToString();
        }
        private void LB10(object sender, RoutedEventArgs e)
        {
            Item = 3003.ToString();
        }
        private void LB11(object sender, RoutedEventArgs e)
        {
            Item = 3504.ToString();
        }
        private void LB12(object sender, RoutedEventArgs e)
        {
            Item = 3174.ToString();
        }
        private void LB13(object sender, RoutedEventArgs e)
        {
            Item = 1038.ToString();
        }
        private void LB14(object sender, RoutedEventArgs e)
        {
            Item = 3751.ToString();
        }
        private void LB15(object sender, RoutedEventArgs e)
        {
            Item = 3060.ToString();
        }
        private void LB16(object sender, RoutedEventArgs e)
        {
            Item = 3102.ToString();
        }
        private void LB17(object sender, RoutedEventArgs e)
        {
            Item = 3006.ToString();
        }
        private void LB18(object sender, RoutedEventArgs e)
        {
            Item = 3144.ToString();
        }
        private void LB19(object sender, RoutedEventArgs e)
        {
            Item = 3153.ToString();
        }
        private void LB20(object sender, RoutedEventArgs e)
        {
            Item = 1026.ToString();
        }
        private void LB21(object sender, RoutedEventArgs e)
        {
            Item = 3117.ToString();
        }
        private void LB22(object sender, RoutedEventArgs e)
        {
            Item = 1001.ToString();
        }
        private void LB23(object sender, RoutedEventArgs e)
        {
            Item = 3009.ToString();
        }
        private void LB24(object sender, RoutedEventArgs e)
        {
            Item = 1051.ToString();
        }
        private void LB25(object sender, RoutedEventArgs e)
        {
            Item = 3010.ToString();
        }
        private void LB26(object sender, RoutedEventArgs e)
        {
            Item = 3133.ToString();
        }
        private void LB27(object sender, RoutedEventArgs e)
        {
            Item = 1031.ToString();
        }
        private void LB28(object sender, RoutedEventArgs e)
        {
            Item = 3028.ToString();
        }
        private void LB29(object sender, RoutedEventArgs e)
        {
            Item = 1018.ToString();
        }
        private void LB30(object sender, RoutedEventArgs e)
        {
            Item = 1029.ToString();
        }
        private void LB31(object sender, RoutedEventArgs e)
        {
            Item = 2033.ToString();
        }
        private void LB32(object sender, RoutedEventArgs e)
        {
            Item = 3801.ToString();
        }
        private void LB33(object sender, RoutedEventArgs e)
        {
            Item = 1083.ToString();
        }
        private void LB34(object sender, RoutedEventArgs e)
        {
            Item = 1042.ToString();
        }
        private void LB35(object sender, RoutedEventArgs e)
        {
            Item = 3742.ToString();
        }
        private void LB36(object sender, RoutedEventArgs e)
        {
            Item = 3812.ToString();
        }
        private void LB37(object sender, RoutedEventArgs e)
        {
            Item = 3902.ToString();
        }
        private void LB38(object sender, RoutedEventArgs e)
        {
            Item = 3137.ToString();
        }
        private void LB39(object sender, RoutedEventArgs e)
        {
            Item = 2054.ToString();
        }
        private void LB40(object sender, RoutedEventArgs e)
        {
            Item = 1055.ToString();
        }
        private void LB41(object sender, RoutedEventArgs e)
        {
            Item = 1056.ToString();
        }
        private void LB42(object sender, RoutedEventArgs e)
        {
            Item = 1054.ToString();
        }
        private void LB43(object sender, RoutedEventArgs e)
        {
            Item = 3147.ToString();
        }
        private void LB44(object sender, RoutedEventArgs e)
        {
            Item = 2138.ToString();
        }
        private void LB45c1(object sender, RoutedEventArgs e)
        {
            Item = 2139.ToString();
        }
        private void LB45(object sender, RoutedEventArgs e)
        {
            Item = 2140.ToString();
        }
        private void LB46(object sender, RoutedEventArgs e)
        {
            Item = 1416.ToString();
        }
        private void LB47(object sender, RoutedEventArgs e)
        {
            Item = 1418.ToString();
        }
        private void LB48(object sender, RoutedEventArgs e)
        {
            Item = 1419.ToString();
        }
        private void LB49(object sender, RoutedEventArgs e)
        {
            Item = 3675.ToString();
        }
        private void LB50(object sender, RoutedEventArgs e)
        {
            Item = 1401.ToString();
        }
        private void LB51(object sender, RoutedEventArgs e)
        {
            Item = 1409.ToString();
        }
        private void LB52(object sender, RoutedEventArgs e)
        {
            Item = 1413.ToString();
        }
        private void LB53(object sender, RoutedEventArgs e)
        {
            Item = 3672.ToString();
        }
        private void LB53c1(object sender, RoutedEventArgs e)
        {
            Item = 3672.ToString();
        }
        private void LB53c2(object sender, RoutedEventArgs e)
        {
            Item = 3672.ToString();
        }
        private void LB53c3(object sender, RoutedEventArgs e)
        {
            Item = 3672.ToString();
        }
        private void LB53c4(object sender, RoutedEventArgs e)
        {
            Item = 3672.ToString();
        }
        private void LB54(object sender, RoutedEventArgs e)
        {
            Item = 1400.ToString();
        }
        private void LB55(object sender, RoutedEventArgs e)
        {
            Item = 1408.ToString();
        }
        private void LB56(object sender, RoutedEventArgs e)
        {
            Item = 1412.ToString();
        }
        private void LB57(object sender, RoutedEventArgs e)
        {
            Item = 3671.ToString();
        }
        private void LB58(object sender, RoutedEventArgs e)
        {
            Item = 3184.ToString();
        }
        private void LB59(object sender, RoutedEventArgs e)
        {
            Item = 3508.ToString();
        }
        private void LB60(object sender, RoutedEventArgs e)
        {
            Item = 3123.ToString();
        }
        private void LB61(object sender, RoutedEventArgs e)
        {
            Item = 2050.ToString();
        }
        private void LB62(object sender, RoutedEventArgs e)
        {
            Item = 2303.ToString();
        }
        private void LB63(object sender, RoutedEventArgs e)
        {
            Item = 2302.ToString();
        }
        private void LB64(object sender, RoutedEventArgs e)
        {
            Item = 2301.ToString();
        }
        private void LB65(object sender, RoutedEventArgs e)
        {
            Item = 3401.ToString();
        }
        private void LB66(object sender, RoutedEventArgs e)
        {
            Item = 1004.ToString();
        }
        private void LB67(object sender, RoutedEventArgs e)
        {
            Item = 3363.ToString();
        }
        private void LB68(object sender, RoutedEventArgs e)
        {
            Item = 3108.ToString();
        }
        private void LB69(object sender, RoutedEventArgs e)
        {
            Item = 3901.ToString();
        }
        private void LB70(object sender, RoutedEventArgs e)
        {
            Item = 3114.ToString();
        }
        private void LB71(object sender, RoutedEventArgs e)
        {
            Item = 3092.ToString();
        }
        private void LB72(object sender, RoutedEventArgs e)
        {
            Item = 3098.ToString();
        }
        private void LB73(object sender, RoutedEventArgs e)
        {
            Item = 3110.ToString();
        }
        private void LB74(object sender, RoutedEventArgs e)
        {
            Item = 3022.ToString();
        }
        private void LB75(object sender, RoutedEventArgs e)
        {
            Item = 3034.ToString();
        }
        private void LB76(object sender, RoutedEventArgs e)
        {
            Item = 1011.ToString();
        }
        private void LB77(object sender, RoutedEventArgs e)
        {
            Item = 3024.ToString();
        }
        private void LB78(object sender, RoutedEventArgs e)
        {
            Item = 3460.ToString();
        }
        private void LB79(object sender, RoutedEventArgs e)
        {
            Item = 3361.ToString();
        }
        private void LB80(object sender, RoutedEventArgs e)
        {
            Item = 3362.ToString();
        }
        private void LB81(object sender, RoutedEventArgs e)
        {
            Item = 3026.ToString();
        }
        private void LB82(object sender, RoutedEventArgs e)
        {
            Item = 2051.ToString();
        }
        private void LB83(object sender, RoutedEventArgs e)
        {
            Item = 3124.ToString();
        }
        private void LB84(object sender, RoutedEventArgs e)
        {
            Item = 3136.ToString();
        }
        private void LB85(object sender, RoutedEventArgs e)
        {
            Item = 3155.ToString();
        }
        private void LB86(object sender, RoutedEventArgs e)
        {
            Item = 3030.ToString();
        }
        private void LB87(object sender, RoutedEventArgs e)
        {
            Item = 3146.ToString();
        }
        private void LB88(object sender, RoutedEventArgs e)
        {
            Item = 3152.ToString();
        }
        private void LB89(object sender, RoutedEventArgs e)
        {
            Item = 3145.ToString();
        }
        private void LB90(object sender, RoutedEventArgs e)
        {
            Item = 1041.ToString();
        }
        private void LB91(object sender, RoutedEventArgs e)
        {
            Item = 2032.ToString();
        }
        private void LB92(object sender, RoutedEventArgs e)
        {
            Item = 1039.ToString();
        }
        private void LB93(object sender, RoutedEventArgs e)
        {
            Item = 3025.ToString();
        }
        private void LB94(object sender, RoutedEventArgs e)
        {
            Item = 3031.ToString();
        }
        private void LB95(object sender, RoutedEventArgs e)
        {
            Item = 3158.ToString();
        }
        private void LB96(object sender, RoutedEventArgs e)
        {
            Item = 3052.ToString();
        }
        private void LB97(object sender, RoutedEventArgs e)
        {
            Item = 3067.ToString();
        }
        private void LB98(object sender, RoutedEventArgs e)
        {
            Item = 2015.ToString();
        }
        private void LB99(object sender, RoutedEventArgs e)
        {
            Item = 3035.ToString();
        }
        private void LB100(object sender, RoutedEventArgs e)
        {
            Item = 3151.ToString();
        }
        private void LB101(object sender, RoutedEventArgs e)
        {
            Item = 3100.ToString();
        }
        private void LB102(object sender, RoutedEventArgs e)
        {
            Item = 3190.ToString();
        }
        private void LB103(object sender, RoutedEventArgs e)
        {
            Item = 1036.ToString();
        }
        private void LB104(object sender, RoutedEventArgs e)
        {
            Item = 3036.ToString();
        }
        private void LB105(object sender, RoutedEventArgs e)
        {
            Item = 3104.ToString();
        }
        private void LB106(object sender, RoutedEventArgs e)
        {
            Item = 3802.ToString();
        }
        private void LB107(object sender, RoutedEventArgs e)
        {
            Item = 3285.ToString();
        }
        private void LB108(object sender, RoutedEventArgs e)
        {
            Item = 3008.ToString();
        }
        private void LB109(object sender, RoutedEventArgs e)
       {
            Item = 3004.ToString();
        }
        private void LB110(object sender, RoutedEventArgs e)
        {
            Item = 3156.ToString();
        }
        private void LB111(object sender, RoutedEventArgs e)
        {
            Item = 3041.ToString();
        }
        private void LB112(object sender, RoutedEventArgs e)
        {
            Item = 3139.ToString();
        }
        private void LB113(object sender, RoutedEventArgs e)
        {
            Item = 3111.ToString();
        }
        private void LB114(object sender, RoutedEventArgs e)
        {
            Item = 3222.ToString();
        }
        private void LB115(object sender, RoutedEventArgs e)
        {
            Item = 3170.ToString();
        }
        private void LB116(object sender, RoutedEventArgs e)
        {
            Item = 3165.ToString();
        }
        private void LB117(object sender, RoutedEventArgs e)
        {
            Item = 3033.ToString();
        }
        private void LB118(object sender, RoutedEventArgs e)
        {
            Item = 3115.ToString();
        }
        private void LB119(object sender, RoutedEventArgs e)
        {
            Item = 1058.ToString();
        }
        private void LB120(object sender, RoutedEventArgs e)
        {
            Item = 1057.ToString();
        }
        private void LB121(object sender, RoutedEventArgs e)
        {
            Item = 3047.ToString();
        }
        private void LB122(object sender, RoutedEventArgs e)
        {
            Item = 3096.ToString();
        }
        private void LB123(object sender, RoutedEventArgs e)
        {
            Item = 1033.ToString();
        }
        private void LB124(object sender, RoutedEventArgs e)
        {
            Item = 3056.ToString();
        }
        private void LB125(object sender, RoutedEventArgs e)
        {
            Item = 3364.ToString();
        }
        private void LB127(object sender, RoutedEventArgs e)
        {
            Item = 2047.ToString();
        }
        private void LB128(object sender, RoutedEventArgs e)
        {
            Item = 3112.ToString();
        }
        private void LB129(object sender, RoutedEventArgs e)
        {
            Item = 3084.ToString();
        }
        private void LB130(object sender, RoutedEventArgs e)
        {
            Item = 3198.ToString();
        }
        private void LB131(object sender, RoutedEventArgs e)
        {
            Item = 3044.ToString();
        }
        private void LB132(object sender, RoutedEventArgs e)
        {
            Item = 3046.ToString();
        }
        private void LB133(object sender, RoutedEventArgs e)
        {
            Item = 1037.ToString();
        }
        private void LB134(object sender, RoutedEventArgs e)
        {
            Item = 2052.ToString();
        }
        private void LB135(object sender, RoutedEventArgs e)
        {
            Item = 3200.ToString();
        }
        private void LB136(object sender, RoutedEventArgs e)
        {
            Item = 3140.ToString();
        }
        private void LB137(object sender, RoutedEventArgs e)
        {
            Item = 3089.ToString();
        }
        private void LB138(object sender, RoutedEventArgs e)
        {
            Item = 3903.ToString();
        }
        private void LB139(object sender, RoutedEventArgs e)
        {
            Item = 3143.ToString();
        }
        private void LB140(object sender, RoutedEventArgs e)
        {
            Item = 3094.ToString();
        }
        private void LB141(object sender, RoutedEventArgs e)
        {
            Item = 2053.ToString();
        }
        private void LB142(object sender, RoutedEventArgs e)
        {
            Item = 3074.ToString();
        }
        private void LB143(object sender, RoutedEventArgs e)
        {
            Item = 1043.ToString();
        }
        private void LB144(object sender, RoutedEventArgs e)
        {
            Item = 2031.ToString();
        }
        private void LB145(object sender, RoutedEventArgs e)
        {
            Item = 1006.ToString();
        }
        private void LB146(object sender, RoutedEventArgs e)
        {
            Item = 3302.ToString();
        }
        private void LB147(object sender, RoutedEventArgs e)
        {
            Item = 3800.ToString();
        }
        private void LB148(object sender, RoutedEventArgs e)
        {
            Item = 3029.ToString();
        }
        private void LB149(object sender, RoutedEventArgs e)
        {
            Item = 3027.ToString();
        }
        private void LB150(object sender, RoutedEventArgs e)
        {
            Item = 1028.ToString();
        }
        private void LB151(object sender, RoutedEventArgs e)
        {
            Item = 2045.ToString();
        }
        private void LB152(object sender, RoutedEventArgs e)
        {
            Item = 3085.ToString();
        }
        private void LB153(object sender, RoutedEventArgs e)
        {
            Item = 3116.ToString();
        }
        private void LB154(object sender, RoutedEventArgs e)
        {
            Item = 3181.ToString();
        }
        private void LB155(object sender, RoutedEventArgs e)
        {
            Item = 1027.ToString();
        }
        private void LB156(object sender, RoutedEventArgs e)
        {
            Item = 3191.ToString();
        }
        private void LB157(object sender, RoutedEventArgs e)
        {
            Item = 3462.ToString();
        }
        private void LB158(object sender, RoutedEventArgs e)
        {
            Item = 3134.ToString();
        }
        private void LB159(object sender, RoutedEventArgs e)
        {
            Item = 3057.ToString();
        }
        private void LB160(object sender, RoutedEventArgs e)
        {
            Item = 2049.ToString();
        }
        private void LB161(object sender, RoutedEventArgs e)
        {
            Item = 3715.ToString();
        }
        private void LB162(object sender, RoutedEventArgs e)
        {
            Item = 3020.ToString();
        }
        private void LB163(object sender, RoutedEventArgs e)
        {
            Item = 3345.ToString();
        }
        private void LB164(object sender, RoutedEventArgs e)
        {
            Item = 3211.ToString();
        }
        private void LB165(object sender, RoutedEventArgs e)
        {
            Item = 3303.ToString();
        }
        private void LB166(object sender, RoutedEventArgs e)
        {
            Item = 3065.ToString();
        }
        private void LB167(object sender, RoutedEventArgs e)
        {
            Item = 3706.ToString();
        }
        private void LB168(object sender, RoutedEventArgs e)
        {
            Item = 3087.ToString();
        }
        private void LB169(object sender, RoutedEventArgs e)
        {
            Item = 3053.ToString();
        }
        private void LB170(object sender, RoutedEventArgs e)
        {
            Item = 3101.ToString();
        }
        private void LB171(object sender, RoutedEventArgs e)
        {
            Item = 3068.ToString();
        }
        private void LB172(object sender, RoutedEventArgs e)
        {
            Item = 3341.ToString();
        }
        private void LB173(object sender, RoutedEventArgs e)
        {
            Item = 3069.ToString();
        }
        private void LB174(object sender, RoutedEventArgs e)
        {
            Item = 3097.ToString();
        }
        private void LB175(object sender, RoutedEventArgs e)
        {
            Item = 3073.ToString();
        }
        private void LB176(object sender, RoutedEventArgs e)
        {
            Item = 3070.ToString();
        }
        private void LB177(object sender, RoutedEventArgs e)
        {
            Item = 3071.ToString();
        }
        private void LB178(object sender, RoutedEventArgs e)
        {
            Item = 3599.ToString();
        }
        private void LB179(object sender, RoutedEventArgs e)
        {
            Item = 3072.ToString();
        }
        private void LB180(object sender, RoutedEventArgs e)
        {
            Item = 1082.ToString();
        }
        private void LB181(object sender, RoutedEventArgs e)
        {
            Item = 3196.ToString();
        }
        private void LB182(object sender, RoutedEventArgs e)
        {
            Item = 3197.ToString();
        }
        private void LB183(object sender, RoutedEventArgs e)
        {
            Item = 3185.ToString();
        }
        private void LB184(object sender, RoutedEventArgs e)
        {
            Item = 3075.ToString();
        }
        private void LB185(object sender, RoutedEventArgs e)
        {
            Item = 3077.ToString();
        }
        private void LB186(object sender, RoutedEventArgs e)
        {
            Item = 3748.ToString();
        }
        private void LB188(object sender, RoutedEventArgs e)
        {
            Item = 2009.ToString();
        }
        private void LB189(object sender, RoutedEventArgs e)
        {
            Item = 2010.ToString();
        }
        private void LB190(object sender, RoutedEventArgs e)
        {
            Item = 3711.ToString();
        }
        private void LB191(object sender, RoutedEventArgs e)
        {
            Item = 3078.ToString();
        }
        private void LB192(object sender, RoutedEventArgs e)
        {
            Item = 1053.ToString();
        }
        private void LB193(object sender, RoutedEventArgs e)
        {
            Item = 2043.ToString();
        }
        private void LB194(object sender, RoutedEventArgs e)
        {
            Item = 3135.ToString();
        }
        private void LB195(object sender, RoutedEventArgs e)
        {
            Item = 3082.ToString();
        }
        private void LB196(object sender, RoutedEventArgs e)
        {
            Item = 3340.ToString();
        }
        private void LB197(object sender, RoutedEventArgs e)
        {
            Item = 3083.ToString();
        }
        private void LB198(object sender, RoutedEventArgs e)
        {
            Item = 3122.ToString();
        }
        private void LB199(object sender, RoutedEventArgs e)
        {
            Item = 3091.ToString();
        }
        private void LB200(object sender, RoutedEventArgs e)
        {
            Item = 3090.ToString();
        }
        private void LB201(object sender, RoutedEventArgs e)
        {
            Item = 3142.ToString();
        }
        private void LB202(object sender, RoutedEventArgs e)
        {
            Item = 3086.ToString();
        }
        private void LB203(object sender, RoutedEventArgs e)
        {
            Item = 3050.ToString();
        }
        private void LB204(object sender, RoutedEventArgs e)
        {
            Item = 3157.ToString();
        }
        private void LB205(object sender, RoutedEventArgs e)
        {
            Item = 3512.ToString();
        }
        #endregion itemler
      /*  private void OlusturBt_OnClick(object sender, RoutedEventArgs e)
        {
            File.WriteAllText(ChampTxBx.Text + "-SummonersRift" + ".txt", Item + ":" + BoS + "," );
        }
        */

        private void AoSSelected(object sender, RoutedEventArgs e)
        {
            BoS = "Buy";
        }

        private void BoS2(object sender, RoutedEventArgs e)
        {
            BoS = "Sell";
        }

        private void StartHpBt_OnClick(object sender, RoutedEventArgs e)
        {
            ListBoxItem esy1 = new ListBoxItem();
            esy1.Content = "Hp Pot Purchasing Started";
            ListBox.Items.Add(esy1);
            using (StreamWriter writer = new StreamWriter(ChampTxBx.Text + "-SummonersRift" + ".txt", true))
            {
                writer.Write("2003:StartHpPot,");
            }
        }

        private void StopHpBt_OnClick(object sender, RoutedEventArgs e)
        {
            ListBoxItem esy2 = new ListBoxItem();
            esy2.Content = "Hp Pot Purchasing Stopped";
            ListBox.Items.Add(esy2);
            using (StreamWriter writer = new StreamWriter(ChampTxBx.Text + "-SummonersRift" + ".txt", true))
            {
                writer.Write("2003:StopHpPot,");
            }
        }
    }
}
