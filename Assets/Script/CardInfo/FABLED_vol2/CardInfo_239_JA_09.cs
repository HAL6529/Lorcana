using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_239_JA_09 : CardInfo
{
    public CardInfo_239_JA_09()
    {
        this.cardNo = "239_JA_09";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "スカー";
        this.cardName2 = "ついに俺が王だ";
        this.power = 5;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JeannePlounevez;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.King };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.Fabled_vol2;
        this.title = EnumController.Title.TheLionKing;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
