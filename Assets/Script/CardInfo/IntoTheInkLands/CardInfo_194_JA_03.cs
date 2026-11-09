using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_194_JA_03 : CardInfo
{
    public CardInfo_194_JA_03()
    {
        this.cardNo = "194_JA_03";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "サディアス・E・クラング";
        this.cardName2 = "鋼の頭目";
        this.power = 3;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JuanDiegoLeon;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.TaleSpin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
