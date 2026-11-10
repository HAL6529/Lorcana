using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_173_JA_03 : CardInfo
{
    public CardInfo_173_JA_03()
    {
        this.cardNo = "173_JA_03";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "巨人のグスタフ";
        this.cardName2 = "王国への脅威";
        this.power = 6;
        this.toughness = 6;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.GiuseppeDiMaio;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
