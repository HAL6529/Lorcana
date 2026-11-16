using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_188_JA_06 : CardInfo
{
    public CardInfo_188_JA_06()
    {
        this.cardNo = "188_JA_06";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "コブラ・バブルス";
        this.cardName2 = "元CIAだ";
        this.power = 3;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.EriWelli;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Bodyguard };
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.LiloAndStitch;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
