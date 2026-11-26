using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_161_JA_14 : CardInfo
{
    public CardInfo_161_JA_14()
    {
        this.cardNo = "161_JA_14";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "羊のダグ";
        this.cardName2 = "沈黙の羊";
        this.power = 3;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.VeronicaDiLorenzoAndLivioCacciatore;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Ward };
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.Zootopia;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
