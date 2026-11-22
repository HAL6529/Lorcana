using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_214_JA_10 : CardInfo
{
    public CardInfo_214_JA_10()
    {
        this.cardNo = "214_JA_10";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ティンカー・ベル";
        this.cardName2 = "キラキラ鑑定中";
        this.power = 3;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.DevinElleKurtz;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Fairy };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Epic;
    }
}
