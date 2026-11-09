using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_157_JA_03 : CardInfo
{
    public CardInfo_157_JA_03()
    {
        this.cardNo = "157_JA_03";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ティンカー・ベル";
        this.cardName2 = "とっても賢い妖精";
        this.power = 3;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.GraceTran;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Ally, EnumController.Class.Fairy };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
