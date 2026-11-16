using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_120_JA_06 : CardInfo
{
    public CardInfo_120_JA_06()
    {
        this.cardNo = "120_JA_06";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "ミニーマウス";
        this.cardName2 = "海賊の見張り番";
        this.power = 3;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AlicePisoni;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Pirate };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
