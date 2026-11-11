using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_179_JA_05 : CardInfo
{
    public CardInfo_179_JA_05()
    {
        this.cardNo = "179_JA_05";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ヘイヘイ";
        this.cardName2 = "お守りニワトリ";
        this.power = 4;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.BrianWeisz;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Bodyguard };
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.Moana;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
