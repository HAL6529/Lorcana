using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_006_JA_08 : CardInfo
{
    public CardInfo_006_JA_08()
    {
        this.cardNo = "006_JA_08";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ミニーマウス";
        this.cardName2 = "勇敢な守り手";
        this.power = 0;
        this.toughness = 8;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AubreyArcher;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber, EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Bodyguard };
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
