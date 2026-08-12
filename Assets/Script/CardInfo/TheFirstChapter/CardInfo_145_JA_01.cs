using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_145_JA_01 : CardInfo
{
    public CardInfo_145_JA_01()
    {
        this.cardNo = "145_JA_01";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ƒtƒ‰ƒ“ƒ_[";
        this.cardName2 = "ˆø‚«~‚ß–ğ";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = "Brian Weisz";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.TheLittleMermaid;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
