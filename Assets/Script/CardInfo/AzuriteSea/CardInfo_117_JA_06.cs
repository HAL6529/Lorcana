using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_117_JA_06 : CardInfo
{
    public CardInfo_117_JA_06()
    {
        this.cardNo = "117_JA_06";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ÉÇÉAÉi";
        this.cardName2 = "é©å»ó¨ÇÃëDèÊÇË";
        this.power = 3;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.Koni;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Princess, EnumController.Class.Pirate};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.Moana;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
