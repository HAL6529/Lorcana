using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_235_JA_12 : CardInfo
{
    public CardInfo_235_JA_12()
    {
        this.cardNo = "235_JA_12";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ジッパー";
        this.cardName2 = "ヘビー級の助っ人";
        this.power = 0;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MaxUlichney;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift2 };
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Chipmunk;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
