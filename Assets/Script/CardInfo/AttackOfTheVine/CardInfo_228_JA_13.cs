using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_228_JA_13 : CardInfo
{
    public CardInfo_228_JA_13()
    {
        this.cardNo = "228_JA_13";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "ウッディ＆バズ・ライトイヤー";
        this.cardName2 = "最高の相棒";
        this.power = 4;
        this.toughness = 4;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.GiacomoBoni;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Team, EnumController.Class.Hero, EnumController.Class.Toy, EnumController.Class.Captain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber, EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift5 };
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.ToyStory;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
