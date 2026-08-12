using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_011_JA_01 : CardInfo
{
    public CardInfo_011_JA_01()
    {
        this.cardNo = "011_JA_01";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "マキシマス";
        this.cardName2 = "しつこい追跡者";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = "Kendall Hale";
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Tangled;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
