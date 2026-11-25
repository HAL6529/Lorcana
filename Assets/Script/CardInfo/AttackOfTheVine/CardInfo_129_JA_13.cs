using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_129_JA_13 : CardInfo
{
    public CardInfo_129_JA_13()
    {
        this.cardNo = "129_JA_13";
        this.inkCost = 9;
        this.availableInk = true;
        this.cardName1 = "ミン・リー";
        this.cardName2 = "私ぶちぎれレッサーパンダ";
        this.power = 10;
        this.toughness = 10;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.GraceTran;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Mentor, EnumController.Class.Giant, EnumController.Class.RedPanda };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.TemporaryShift7 };
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.TurningRed;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
