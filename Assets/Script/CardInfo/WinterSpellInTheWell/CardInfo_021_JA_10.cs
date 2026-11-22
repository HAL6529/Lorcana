using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_021_JA_10 : CardInfo
{
    public CardInfo_021_JA_10()
    {
        this.cardNo = "021_JA_10";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "グーフィー";
        this.cardName2 = "お化け退治屋";
        this.power = 4;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JanelReh;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Detective };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
