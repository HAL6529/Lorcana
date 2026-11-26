using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_155_JA_14 : CardInfo
{
    public CardInfo_155_JA_14()
    {
        this.cardNo = "155_JA_14";
        this.inkCost = 8;
        this.availableInk = true;
        this.cardName1 = "ミニーマウス";
        this.cardName2 = "都市の設計家";
        this.power = 6;
        this.toughness = 6;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.FedericoMariaCugliari;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Ward };
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
