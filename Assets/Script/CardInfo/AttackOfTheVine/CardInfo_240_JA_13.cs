using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_240_JA_13 : CardInfo
{
    public CardInfo_240_JA_13()
    {
        this.cardNo = "240_JA_13";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "メイ・リー";
        this.cardName2 = "超有名レッサーパンダ";
        this.power = 4;
        this.toughness = 5;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.EricTan;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.RedPanda };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.TemporaryShift3 };
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.TurningRed;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
