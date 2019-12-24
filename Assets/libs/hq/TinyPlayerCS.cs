// Generated by Haxe 4.1.0-rc.1+0d88c583b
using haxe.root;
using Newtonsoft.Json;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace web
{
    public class TinyPlayerCS
    {




        public int id;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public uint? roomCard;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public float? oriMoney;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int[] cards;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public float? money;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public float? money_clone;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public float? earnMoney;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public float? loseMoney;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public uint? scroe;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? isBanker;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? status;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public uint? isGM;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? roomID;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? clubID;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public float? canGetMoney;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string nick_name;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? fk;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? gailv;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string openID;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string password;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string avatar;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? sex;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string phone;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public uint? seat;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        //public global::server.IHander hander;

        public double? searchRoomID;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? isRobot;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public float? resultEarnMoney;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public float? resultLostMoney;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string scoreTip;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? inGame;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string mobile;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string cardTimes;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? referenceID;//推荐人
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public float? coins;//动态奖励，道具币
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public float? staticCoins;//静态 币
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public float? bccmCoins;//bccm币
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public float? investCoins;//总共个人买了多少币。不计算他输的。

        //-----------------------收益

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public float? recommendIncome;//推荐奖，动态收益
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public float? tearmIncome;//动态收益 团队奖无限代
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public float? dividentsIncome;//分红收益 动态收益 无限代
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? tearmSize;//团队人数

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? firstSize;//有效直推第一层

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public float? staticIncome;//静态受益 


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? level;//等级

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public float? contributionIncome;//贡献值

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? thirdPartID;//第三方ID


    }
}






