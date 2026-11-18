using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_078_JA_08 : CardInfo
{
    public CardInfo_078_JA_08()
    {
        this.cardNo = "078_JA_08";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "戻って来るときは姿が違う";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.SauloNate;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Pinocchio;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Uncommon;
    }
}
