using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_026_JA_14 : CardInfo
{
    public CardInfo_026_JA_14()
    {
        this.cardNo = "026_JA_14";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "ミゲル・リヴェラ";
        this.cardName2 = "大成した音楽家";
        this.power = 4;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.ValerioBuonfantinoAndAmandaDuarte;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift3 };
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.Coco;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
