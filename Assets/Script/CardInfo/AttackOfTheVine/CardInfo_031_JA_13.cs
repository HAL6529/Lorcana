using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_031_JA_13 : CardInfo
{
    public CardInfo_031_JA_13()
    {
        this.cardNo = "031_JA_13";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "リロ＆スティッチ";
        this.cardName2 = "わんぱくなかよしオハナ";
        this.power = 3;
        this.toughness = 5;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.SerenaWade;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Team, EnumController.Class.Hero, EnumController.Class.Alien };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber, EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift3, EnumController.KeywordAvility.Resist1, EnumController.KeywordAvility.Support };
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.LiloAndStitch;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
