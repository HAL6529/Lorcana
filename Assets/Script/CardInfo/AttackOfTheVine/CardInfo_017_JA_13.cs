using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_017_JA_13 : CardInfo
{
    public CardInfo_017_JA_13()
    {
        this.cardNo = "017_JA_13";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "４★TOWN";
        this.cardName2 = "今年一番ホットなグループ";
        this.power = 5;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.Koni;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Singer5 };
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.TurningRed;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
