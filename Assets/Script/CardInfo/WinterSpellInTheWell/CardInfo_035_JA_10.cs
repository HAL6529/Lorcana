using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_035_JA_10 : CardInfo
{
    public CardInfo_035_JA_10()
    {
        this.cardNo = "035_JA_10";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ミニーマウス";
        this.cardName2 = "アメジストの勇者";
        this.power = 2;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.LisaParfenova;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
