using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_022_JA_03 : CardInfo
{
    public CardInfo_022_JA_03()
    {
        this.cardNo = "022_JA_03";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "ティンカー・ベル";
        this.cardName2 = "気前よい妖精";
        this.power = 1;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AishaDurmagambetova;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Fairy };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
