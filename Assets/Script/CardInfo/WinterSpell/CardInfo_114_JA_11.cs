using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_114_JA_11 : CardInfo
{
    public CardInfo_114_JA_11()
    {
        this.cardNo = "114_JA_11";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "アグナル！";
        this.cardName2 = "アレンデールの王";
        this.power = 3;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.PatriBalanovsky;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Mentor, EnumController.Class.King };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
