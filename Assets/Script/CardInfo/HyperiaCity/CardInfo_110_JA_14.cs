using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_110_JA_14 : CardInfo
{
    public CardInfo_110_JA_14()
    {
        this.cardNo = "110_JA_14";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "ドナルドダック";
        this.cardName2 = "タクシードライバー";
        this.power = 4;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.FedericoMariaCugliari;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
