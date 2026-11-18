using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_206_JA_08 : CardInfo
{
    public CardInfo_206_JA_08()
    {
        this.cardNo = "206_JA_08";
        this.inkCost = 7;
        this.availableInk = false;
        this.cardName1 = "レック・イット・ラルフ";
        this.cardName2 = "あばれん坊くん";
        this.power = 7;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.SamNielson;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Hero, EnumController.Class.Racer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber, EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift5 };
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.WreckItRalph;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
