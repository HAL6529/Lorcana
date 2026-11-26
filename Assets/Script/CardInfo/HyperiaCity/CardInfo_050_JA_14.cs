using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_050_JA_14 : CardInfo
{
    public CardInfo_050_JA_14()
    {
        this.cardNo = "050_JA_14";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ブルックリン";
        this.cardName2 = "バイクでぶっ飛ばし";
        this.power = 1;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.DevinYang;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Ally, EnumController.Class.Gargoyle };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.Gargoyles;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
