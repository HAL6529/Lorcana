using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_112_JA_04 : CardInfo
{
    public CardInfo_112_JA_04()
    {
        this.cardNo = "112_JA_04";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ÉäÅ[ÅEÉVÉÉÉì";
        this.cardName2 = "óEñ“Ç»ÇÈè´åR";
        this.power = 3;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.NicolaSaviori;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.ShiftDiscardAnCharacterCard };
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Mulan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
