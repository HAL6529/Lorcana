using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_202_JA_01 : CardInfo
{
    public CardInfo_202_JA_01()
    {
        this.cardNo = "202_JA_01";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ƒtƒ‰ƒCƒpƒ“";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = "Kamil Murzyn";
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Tangled;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Uncommon;
    }
}
