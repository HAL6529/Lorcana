using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_120_JA_13 : CardInfo
{
    public CardInfo_120_JA_13()
    {
        this.cardNo = "120_JA_13";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "ウーおばあちゃん";
        this.cardName2 = "モーレツ・レッサーパンダ";
        this.power = 5;
        this.toughness = 7;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MaliaEwart;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Mentor, EnumController.Class.RedPanda };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.TemporaryShift4 };
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.TurningRed;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
