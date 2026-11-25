using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_239_JA_13 : CardInfo
{
    public CardInfo_239_JA_13()
    {
        this.cardNo = "239_JA_13";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ラプンツェル＆フリン・ライダー";
        this.cardName2 = "出会うはずのなかったふたり";
        this.power = 4;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JanePica;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Team, EnumController.Class.Hero, EnumController.Class.Prince, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald, EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift3 };
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.Tangled;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
